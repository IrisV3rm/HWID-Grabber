using Classes;
using System;

namespace HWID_Grabber
{
    class Program
    {
        static void Main(string[] args)
        {
            Grabber grabber = new Grabber();
            Console.WriteLine(grabber.GetMonitorID());
            Console.WriteLine(grabber.GetOwnerIdentity());
            Console.WriteLine(grabber.GetCPUID());
            Console.WriteLine(grabber.GetFanID());
            Console.WriteLine(grabber.GetWin32("Win32_IDEController", "PNPDeviceID"));
            Console.WriteLine(grabber.GetUSBID());
            Console.WriteLine(grabber.GetBaseboardID());
            Console.WriteLine(grabber.GetMemoryID());
            Console.WriteLine(grabber.GetGPUID());
            Console.ReadKey();
        }
    }
}
