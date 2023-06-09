// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of ImplementAllInterface<int> using cast expr
// </Description> 
// <RelatedBugs> </RelatedBugs>  
//<Expects Status=success></Expects>
// <Code> 


using System.Runtime.InteropServices;
using System;
using Xunit;

public class NullableTest
{
    private static bool BoxUnboxToNQ(object o)
    {
        return Helper.Compare((ImplementAllInterface<int>)(ValueType)o, Helper.Create(default(ImplementAllInterface<int>)));
    }

    private static bool BoxUnboxToQ(object o)
    {
        return Helper.Compare((ImplementAllInterface<int>?)(ValueType)o, Helper.Create(default(ImplementAllInterface<int>)));
    }

    [Fact]
    public static int TestEntryPoint()
    {
        ImplementAllInterface<int>? s = Helper.Create(default(ImplementAllInterface<int>));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


