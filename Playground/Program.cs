using System;
using System.Net.NetworkInformation;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            for (int i = 0; i < nics.Length; i++)
            {
                Console.WriteLine(i + " ==> " + nics[i].GetPhysicalAddress().ToString() + " -- " + nics[i].OperationalStatus);
            }
        }
    }
}
