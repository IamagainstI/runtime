// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

.assembly extern legacy library mscorlib {}
.assembly extern xunit.core {}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}
.assembly 'b84136'{}
.class public conv {
.method public static float32 r4(float32) {
.maxstack	2
	ldarg	0
	ret
}
.method public static int32 main() {
.custom instance void [xunit.core]Xunit.FactAttribute::.ctor() = (
    01 00 00 00
)
.entrypoint
.maxstack	10
        ldc.r4  -1.0
        dup
        call    float32 conv::r4(float32)
        ceq
        brfalse FAIL
PASS:
	ldc.i4	100
	ret
FAIL:
	ldc.i4	0x0
	ret
}
}
