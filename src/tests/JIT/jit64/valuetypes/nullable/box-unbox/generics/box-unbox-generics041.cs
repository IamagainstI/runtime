// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System.Runtime.InteropServices;
using System;
using Xunit;

public class NullableTest
{
    private static bool BoxUnboxToNQ<T>(T o)
    {
        return Helper.Compare((ImplementTwoInterfaceGen<int>)(object)o, Helper.Create(default(ImplementTwoInterfaceGen<int>)));
    }

    private static bool BoxUnboxToQ<T>(T o)
    {
        return Helper.Compare((ImplementTwoInterfaceGen<int>?)(object)o, Helper.Create(default(ImplementTwoInterfaceGen<int>)));
    }

    [Fact]
    public static int TestEntryPoint()
    {
        ImplementTwoInterfaceGen<int>? s = Helper.Create(default(ImplementTwoInterfaceGen<int>));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


