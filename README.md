# HWID-Grabber
C# HWID Grabber using ManagementObjectSearcher


```cs
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
```
