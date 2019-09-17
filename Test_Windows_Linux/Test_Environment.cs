/*
    <Windows 실행결과>
    -------------------------------------------------------------
    Environment.OSVersion: Microsoft Windows NT 10.0.17763.0
    Environment.OSVersion.Platform: Win32NT

    <Ubuntu 실행결과>
    -------------------------------------------------------------
    Environment.OSVersion: Unix 5.0.0.27
    Environment.OSVersion.Platform: Unix
    Environment.ProcessorCount: 24 ea
    Environment.Version: 3.0.0
    Environment.Is64BitOperatingSystem: True
    Environment.MachineName: VTD
    Environment.UserName: thomas
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Windows_Linux
{
    class Test_Environment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Environment.OSVersion: " + Environment.OSVersion);
            Console.WriteLine("Environment.OSVersion.Platform: " + Environment.OSVersion.Platform);
            Console.WriteLine("Environment.ProcessorCount: {0} ea", Environment.ProcessorCount);
            Console.WriteLine("Environment.Version: {0}", Environment.Version);
            Console.WriteLine("Environment.Is64BitOperatingSystem: {0}", Environment.Is64BitOperatingSystem);
            Console.WriteLine("Environment.MachineName: {0}", Environment.MachineName);
            Console.WriteLine("Environment.UserName: {0}", Environment.UserName);
        }      
    }
}
