// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of ImplementOneInterface using cast expr
// </Description> 
// <RelatedBugs> </RelatedBugs>  
//<Expects Status=success></Expects>
// <Code> 


using System.Runtime.InteropServices;
using System;
using Xunit;

public class NullableTest
{
    private static bool BoxUnboxToNQ<T>(T o)
    {
        return Helper.Compare((ImplementOneInterface)(ValueType)(object)o, Helper.Create(default(ImplementOneInterface)));
    }

    private static bool BoxUnboxToQ<T>(T o)
    {
        return Helper.Compare((ImplementOneInterface?)(ValueType)(object)o, Helper.Create(default(ImplementOneInterface)));
    }

    [Fact]
    public static int TestEntryPoint()
    {
        ImplementOneInterface? s = Helper.Create(default(ImplementOneInterface));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


