﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.MathBenchmarks
{
    public partial class Double
    {
        // Tests Math.Min(double) over 5000 iterations for the domain -1, +1

        private const double minDelta = 0.0004;
        private const double minExpectedResult = 1.0;

        public void Min() => MinTest();

        public static void MinTest()
        {
            double result = 0.0, val1 = 1.0, val2 = 1.0 + minDelta;

            for (int iteration = 0; iteration < MathTests.Iterations; iteration++)
            {
                val2 -= minDelta;
                result += Math.Min(val1, val2);
            }

            double diff = Math.Abs(minExpectedResult - result);

            if (diff > MathTests.DoubleEpsilon)
            {
                throw new Exception($"Expected Result {minExpectedResult,20:g17}; Actual Result {result,20:g17}");
            }
        }
    }
}
