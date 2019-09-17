/*
    <Windows 실행결과>
    -------------------------------------------------------------
    Environment.OSVersion: Microsoft Windows NT 10.0.17763.0
    Environment.OSVersion.Platform: Win32NT
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
        }      
    }
}
