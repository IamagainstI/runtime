# WebAssembly AOT code generation

## Basic operation

The LLVM backend of the Mono JIT is used to generate an llvm .bc file for each assembly, then the .bc files are
compiled to webassembly using emscripten, then the resulting wasm files are linked into the final app. The 'bitcode'/'llvmonly'
variant of the LLVM backend is used since webassembly doesn't support inline assembly etc.

## GC Support

On wasm, the execution stack is not stored in linear memory, so its not possible to scan it for GC references. However, there
is an additional C stack which stores variables whose addresses are taken. Variables which hold GC references are marked as
'volatile' in the llvm backend, forcing llvm to spill those to the C stack so they can be scanned.

## Interpreter support

Its possible for AOTed and interpreted code to interop, this is called mixed mode.
For the AOT -> interpreter case, every call from AOTed code which might end up in the interpreter is
emitted as an indirect call. When the callee is not found, a wrapper function is used which
packages up the arguments into an array and passes control to the interpreter.
For the interpreter -> AOT case, and similar wrapper function is used which receives the
arguments and a return value pointer from the interpreter in an array, and calls the
AOTed code. There is usually one aot->interp and interp->aot wrapper for each signature, with
some sharing. These wrappers are generated by the AOT compiler when the 'interp' aot option
is used.

## Null checks

Since wasm has no signal support, we generate explicit null checks.

## Issues

The generated code is in general much bigger than the code generated on ios etc. Some of the
current issues are described below.

### Function pointers

The runtime needs to be able to do a IL method -> wasm function lookup. To do this, every
AOT image includes a table mapping from a method index to wasm functions. This means that
every generated AOT method has its address taken, which severely limits the interprocedural
optimizations that LLVM can do, since it cannot determine the set of callers for a function.
This means that it cannot remove functions corresponding to unused IL methods, cannot
specialize functions for constant/nonnull arguments, etc.
The dotnet ILLink tool includes some support for adding a [DisablePrivateReflection] attribute to
methods which cannot be called using reflection, and the AOT compiler could use this
to avoid generating function pointers for methods which are not called from outside the
AOT image. This is not enabled right now because the ILLink tool support is not complete.

### Null checks

The explicit null checking code adds a lot of size overhead since null checks are very common.

### Virtual calls

Vtable slots are lazily initialized on the first call, i.e. every virtual call looks like this:
```C
vt_entry = vtable [slot];
if (vt_entry == null)
	vt_entry = init_vt_entry ();
```

### GC overhead

Since GC variables are marked as volatile and stored on the C stack, they are loaded/stored on every access,
even if there is no GC safe point between the accesses. Instead, they should only be loaded/stored around
GC safe points.
