// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

.assembly extern legacy library mscorlib {}
.assembly extern xunit.core {}
.assembly extern System.Console
{
  .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A )
  .ver 4:0:0:0
}
.assembly b14067a
{
}
.class public ILGEN_622380794 {

.field static	int64 field_0x5

.method public static int32 main() {
.custom instance void [xunit.core]Xunit.FactAttribute::.ctor() = (
    01 00 00 00
)
.entrypoint
.maxstack	20

 ldsflda int64 ILGEN_622380794::field_0x5
 ldind.i8
 conv.u
 conv.r.un
 conv.i4
ldc.i4 100
add
 ret
}
}
