// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.Text.Json
{
    public sealed partial class JsonDocument
    {
        // SizeOrLength - offset - 0 - size - 4
        // NumberOfRows - offset - 4 - size - 4
        [StructLayout(LayoutKind.Sequential)]
        private readonly struct StackRow
        {
            internal const int Size = 8;

            internal readonly int SizeOrLength;
            internal readonly int NumberOfRows;

            internal StackRow(int sizeOrLength = 0, int numberOfRows = -1)
            {
                Debug.Assert(sizeOrLength >= 0);
                Debug.Assert(numberOfRows >= -1);

                SizeOrLength = sizeOrLength;
                NumberOfRows = numberOfRows;
            }
        }
    }
}
