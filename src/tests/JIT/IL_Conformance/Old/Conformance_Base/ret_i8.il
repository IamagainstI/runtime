// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

.assembly extern legacy library mscorlib {}
.assembly extern xunit.core {}


.namespace ret_i8
{
.class public		_ret {



.method public static		int64 ret_test(int64) {
.maxstack	1
	ldarg	0
	ret
}

.method public		void _ret() {
.maxstack	0
	ret
}

.method public static	int32 main() {
.custom instance void [xunit.core]Xunit.FactAttribute::.ctor() = (
    01 00 00 00
)
.entrypoint
.maxstack		9
	ldc.i8		0xAAAAAAAAAAAAAAAA
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0xAAAAAAAAAAAAAAAA
	ceq
	brfalse		FAIL

	ldc.i8		0x5555555555555555
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0x5555555555555555
	ceq
	brfalse		FAIL

	ldc.i8		0x7FFFFFFFFFFFFFFF
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0x7FFFFFFFFFFFFFFF
	ceq
	brfalse		FAIL

	ldc.i8		0x0000000000000001
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0x0000000000000001
	ceq
	brfalse		FAIL

	ldc.i8		0x0000000000000000
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0x0000000000000000
	ceq
	brfalse		FAIL

	ldc.i8		0xFFFFFFFFFFFFFFFF
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0xFFFFFFFFFFFFFFFF
	ceq
	brfalse		FAIL

	ldc.i8		0x8000000000000000
	call	int64 ret_i8._ret::ret_test(int64)
	ldc.i8		0x8000000000000000
	ceq
	brfalse		FAIL


PASS:
	ldc.i4 100
	br		END

FAIL:
	ldc.i4	0x00000000

END:
	ret
}
}

.assembly ret_i8{}
}
