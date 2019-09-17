/*
    2019.09.17 17:22
    윈도우에서 실행하면 예상한 결과를 확인할 수 있었지만,
    우분투에서 실행하면 예상하지 못한 결과(예: My address is : 127.0.1.1)가 나온다.
 */
using System;
using System.Net;
using System.Net.NetworkInformation;

namespace Test_Windows_Linux
{
    class Test_System_Net
    {
        static void Main(string[] args)
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            Console.WriteLine("Interface information for {0}.{1}     ",
                    computerProperties.HostName, computerProperties.DomainName);
            foreach (NetworkInterface adapter in nics)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Console.WriteLine(adapter.Description);
                Console.WriteLine(String.Empty.PadLeft(adapter.Description.Length, '='));
                Console.WriteLine("  Interface type .......................... : {0}", adapter.NetworkInterfaceType);
                Console.WriteLine("  Physical Address ........................ : {0}", adapter.GetPhysicalAddress().ToString());
                // ubuntu 18.04 에서는 오류가 발생한다. 원인모름.
                //Console.WriteLine("  Is receive only.......................... : {0}", adapter.IsReceiveOnly);
                Console.WriteLine("  Multicast................................ : {0}", adapter.SupportsMulticast);

                Console.WriteLine();
            }



            IPAddress[] localIPs = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress addr in localIPs)
            {
                if (addr.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    Console.WriteLine($"My address is : {addr}");
                }
            }
        }
    }
}
