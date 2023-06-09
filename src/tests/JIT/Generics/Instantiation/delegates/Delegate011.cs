// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using Xunit;

internal delegate T GenDelegate<T>(T p1, out T p2);

internal struct Foo
{
    public T Function<T>(T i, out T j)
    {
        j = i;
        return i;
    }
}

public class Test_Delegate011
{
    [Fact]
    public static int TestEntryPoint()
    {
        int i, j;
        Foo inst = new Foo();
        GenDelegate<int> MyDelegate = new GenDelegate<int>(inst.Function<int>);
        i = MyDelegate(10, out j);

        if ((i != 10) || (j != 10))
        {
            Console.WriteLine("Failed Sync Invocation");
            return 1;
        }

        Console.WriteLine("Test Passes");
        return 100;
    }
}

