// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Generated by Fuzzlyn v1.5 on 2022-02-27 18:35:07
// Run on X86 Windows
// Seed: 14567735315501116995
// Reduced from 12.1 KiB to 0.5 KiB in 00:01:37
// Debug: Outputs 2
// Release: Outputs 1

using System.Runtime.CompilerServices;
using Xunit;

public struct S0
{
    public ulong F1;
}

public struct S1
{
    public S0 F6;
}

public class Runtime_66242
{
    public static short s_3;
    [Fact]
    public static int TestEntryPoint()
    {
        var vr3 = new S1();
        if (vr3.F6.F1 < M4(ref vr3))
        {
            int vr9 = s_3++;
        }

        return s_3 + 98;
    }

    public static uint M4(ref S1 arg1)
    {
        int var0 = s_3++;
        arg1.F6.F1 = 16700531892663534200UL;
        return 1;
    }
}
