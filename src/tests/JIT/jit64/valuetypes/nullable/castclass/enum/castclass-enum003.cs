// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// <Area> Nullable - CastClass </Area>
// <Title> Nullable type with castclass expr  </Title>
// <Description>  
// checking type of LongE using cast expr
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
        return Helper.Compare((LongE)(Enum)o, Helper.Create(default(LongE)));
    }

    private static bool BoxUnboxToQ(object o)
    {
        return Helper.Compare((LongE?)(Enum)o, Helper.Create(default(LongE)));
    }

    [Fact]
    public static int TestEntryPoint()
    {
        LongE? s = Helper.Create(default(LongE));

        if (BoxUnboxToNQ(s) && BoxUnboxToQ(s))
            return ExitCode.Passed;
        else
            return ExitCode.Failed;
    }
}


