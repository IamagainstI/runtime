// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using Xunit;

/// <summary>
/// Verifies passing an invalid handle (not overlapped) to BindHandle works as expected
/// </summary>
public class BindHandle1
{
    [Fact]
    public static int TestEntryPoint()
    {
        return (new BindHandle1().RunTest());
    }

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
    public static extern IntPtr CreateFile(String FileName, uint Access, uint Share, int Atts, uint Dispo, uint Flags, int Template);


    int RunTest()
    {
        try
        {
            try
            {
                using (SafeFileHandle sfh = new SafeFileHandle(CreateFile("test.txt", 0x40000000, 0, 0, 2, 0x40000000, 0), true))
                {
                    if (ThreadPool.BindHandle(sfh))
                    {
                        Console.WriteLine("BindHandle call succeeded");
                    }
                    else
                    {
                        Console.WriteLine("Unexpected: BindHandle call failed");
                        return (98);
                    }

                    Console.WriteLine("Test passed");
                    return (100);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected exception - HResult: 0x{ex.HResult:x}, Exception: {ex}");
                return (98);
            }
        }
        finally
        {
            if (File.Exists("test.txt"))
            {
                File.Delete("test.txt");
            }
        }
    }


}
