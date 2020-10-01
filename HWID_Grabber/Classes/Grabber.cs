
using System.Management;
using System.Security.Principal;

namespace Classes
{
    public class Grabber
    {
        string Result;
        public string GetOwnerIdentity(bool ReturnDashes = false)
        {
            if (ReturnDashes)
            {
                return WindowsIdentity.GetCurrent().Owner.Value.ToString();
            }
            else
            {
                return WindowsIdentity.GetCurrent().Owner.Value.ToString().Replace("-", "");
            }
        }

        public string GetCPUID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["ProcessorId"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetFanID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["SerialNumber"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }                    
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetWin32(string Selection, string ID)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher($"SELECT * FROM {Selection}");
            foreach (ManagementObject os in searcher.Get())
            {
                try
                {
                    Result = os[ID].ToString();
                }
                catch { return "0"; }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetUSBID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["PNPDeviceID"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetBaseboardID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["SerialNumber"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetMemoryID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["PartNumber"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetGPUID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["PNPDeviceID"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }

        public string GetMonitorID(string ID = "")
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DesktopMonitor");
            foreach (ManagementObject os in searcher.Get())
            {
                if (ID == string.Empty)
                    Result = os["PNPDeviceID"].ToString();
                else
                {
                    try
                    {
                        Result = os[ID].ToString();
                    }
                    catch { return "0"; }
                }
                break;
            }
            searcher.Dispose();
            return Result;
        }
    }
}
