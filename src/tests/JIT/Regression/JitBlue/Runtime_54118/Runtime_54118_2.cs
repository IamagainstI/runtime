// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Xunit;

// Generated by Fuzzlyn v1.2 on 2021-07-22 13:36:33
// Seed: 11656046881568048475
// Reduced from 224.5 KiB to 0.4 KiB in 00:02:42
// Debug: Outputs 1
// Release: Outputs 0

public class Program
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    static bool Eval(byte b) => b == 100;

    static ulong[] s_34 = new ulong[]{0};
    [Fact]
    public static int TestEntryPoint()
    {
        byte[] vr1 = new byte[]{0};
        bool result = false;
        for (int vr2 = 0; vr2 < 2; vr2++)
        {
            for (int vr3 = 0; vr3 < 1; vr3++)
            {
                ulong vr4 = s_34[0]++;
            }

            vr1[0] = 100;
            var vr5 = vr1[0];
            result = Eval(vr5);
        }

        return result ? 100 : -1;
    }
}
