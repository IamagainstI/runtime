// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using Xunit;

public class Runtime_55140
{
    private static int _value;

    [Fact]
    public static int TestEntryPoint()
    {
        _value = 100;
        if (TestSubNegNeg() is not 1 and var subNegNeg)
        {
            Console.WriteLine($"TestSubNegNeg returned: {subNegNeg}. Expected: 1");
            return 101;
        }

        _value = 100;
        if (TestAddNeg() is not 1 and var addNeg)
        {
            Console.WriteLine($"TestAddNeg returned: {addNeg}. Expected: 1");
            return 102;
        }

        return 100;
    }

    // Test that the ADD(NEG(a), b) => SUB(b, a) transform does not reorder persistent side effects.
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int TestAddNeg()
    {
        return -Increment() + _value;
    }

    // Test that the SUB(NEG(a), NEG(b)) => SUB(b, a) transform does not reorder persistent side effects.
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int TestSubNegNeg()
    {
        return -Increment() - -_value;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int Increment() => _value++;
}
