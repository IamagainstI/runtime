// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

.assembly HandlesInAddrModes { }
.assembly extern xunit.core {}
.assembly extern System.Runtime { .publickeytoken = (B0 3F 5F 7F 11 D5 0A 3A ) }

.class public HandlesInAddrModes
{
  .method public static int32 Main()
  {
    .custom instance void [xunit.core]Xunit.FactAttribute::.ctor() = (
        01 00 00 00
    )
    .entrypoint

    ldc.i4 0
    conv.i
    call char .this::Problem(native int)
    ldc.i4 120 // 'x'
    ceq
    ldc.i4 100
    mul
    ret
  }

  .method private static char Problem(native int idx) noinlining
  {
    ldstr "xyz"
    call instance char& modreq([System.Runtime]System.Runtime.InteropServices.InAttribute) string::GetPinnableReference()
    ldarg idx
    ldc.i4 2
    conv.i
    mul
    add
    ldind.u2
    ret
  }
}
