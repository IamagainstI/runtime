// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of NotEmptyStructConstrainedGenQ<int> using cast expr
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
        return Helper.Compare((NotEmptyStructConstrainedGenQ<int>)(ValueType)o, Helper.Create(default(NotEmptyStructConstrainedGenQ<int>)));
    }

    private static bool BoxUnboxToQ(object o)
    {
        return Helper.Compare((NotEmptyStructConstrainedGenQ<int>?)(ValueType)o, Helper.Create(default(NotEmptyStructConstrainedGenQ<int>)));
    }

    [Fact]
    public static int TestEntryPoint()
    {
        NotEmptyStructConstrainedGenQ<int>? s = Helper.Create(default(NotEmptyStructConstrainedGenQ<int>));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


