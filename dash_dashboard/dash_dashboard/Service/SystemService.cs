using System;
using System.Diagnostics;
using System.IO;

namespace dash_dashboard.Service
{
    public class SystemService : ISystemService
    {
        public string getProcessInfo()
        {
            var proc = Process.GetCurrentProcess();
            var mem = proc.WorkingSet64;
            var cpu = proc.TotalProcessorTime;
            var result = $"My process used working set {mem / 1024.0} K of working set and CPU {cpu.TotalMilliseconds} msec";

            return result;
        }

        public string getDiskUsage()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            var size = "";
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                if (drive.IsReady) size += $" {drive.TotalSize}";
            }
            return size;
        }
    }
}
