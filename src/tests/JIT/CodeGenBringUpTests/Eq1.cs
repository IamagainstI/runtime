// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//


using System;
using System.Runtime.CompilerServices;
using Xunit;
public class BringUpTest_Eq1
{
    const int Pass = 100;
    const int Fail = -1;

    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    public static bool Eq1(int x)
    {
        return x == 1;
    }

    [Fact]
    public static int TestEntryPoint()
    {
        bool y = Eq1(1);
        if (y == true) return Pass;
        else return Fail;
    }
}
