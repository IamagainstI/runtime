// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Sys
    {
        [LibraryImport(Interop.Libraries.SystemNative, EntryPoint = "SystemNative_GetTimeZoneData", StringMarshalling = StringMarshalling.Utf8, SetLastError = true)]
        internal static partial IntPtr GetTimeZoneData(string fileName, out int length);
    }
}
