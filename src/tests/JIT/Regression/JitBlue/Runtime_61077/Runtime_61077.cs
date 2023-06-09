// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Generated by Fuzzlyn v1.5 on 2021-10-31 17:07:34
// Run on X86 Windows
// Seed: 493124741082014941
// Reduced from 80.3 KiB to 0.2 KiB in 00:02:01
// Debug: Outputs 2
// Release: Outputs 0
using System.Runtime.CompilerServices;
using Xunit;

public class Runtime_61077
{
    [Fact]
    public static int TestEntryPoint()
    {
        return Go() == 2 ? 100 : -1;
    }

    public static long s_14 = 1;
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static long Go()
    {
        long vr7 = s_14;
        long vr6 = (-1 * -vr7) + vr7;
        return vr6;
    }
}
