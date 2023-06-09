// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//

using Xunit;
namespace Test
{
    using System;

    public class BB
    {
        static int[] Static2() { return new int[100]; }

        static void Method4()
        {
            bool[] local2 = new bool[2];
            if (local2[10])
            { //generate exception
                try { }
                finally
                {
                    int n = Static2()[0];
                    while (Static2()[0] != 0)
                    {
                        try { }
                        finally { }
                    }
                }
            }
        }
        [Fact]
        public static int TestEntryPoint()
        {
            try
            {
                Method4();
            }
            catch (Exception) { return 100; }
            return -1;
        }
    }
}
