// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//

using Xunit;
namespace Test
{
    using System;

    public class BB
    {

        public static String Method3()
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (DivideByZeroException)
            {
                sbyte local2 = (new sbyte[33])[10];
            }
            return null;
        }

        [Fact]
        public static int TestEntryPoint()
        {
            try
            {
                Method3();
                return 1;
            }
            catch (NullReferenceException)
            {
                return 100;
            }
        }
    }
}
