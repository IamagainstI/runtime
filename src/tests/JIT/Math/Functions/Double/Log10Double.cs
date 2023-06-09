﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace System.MathBenchmarks
{
    public partial class Double
    {
        // Tests Math.Log10(double) over 5000 iterations for the domain -1, +1

        private const double log10Delta = 0.0004;
        private const double log10ExpectedResult = -664.07384902184072;

        /// <summary>
        /// this benchmark is dependent on loop alignment
        /// </summary>
        public void Log10() => Log10Test();

        public static void Log10Test()
        {
            double result = 0.0, value = 0.0;

            for (int iteration = 0; iteration < MathTests.Iterations; iteration++)
            {
                value += log10Delta;
                result += Math.Log10(value);
            }

            double diff = Math.Abs(log10ExpectedResult - result);

            if (diff > MathTests.DoubleEpsilon)
            {
                throw new Exception($"Expected Result {log10ExpectedResult,20:g17}; Actual Result {result,20:g17}");
            }
        }
    }
}
