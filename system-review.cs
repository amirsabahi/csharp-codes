using System;
using System.Diagnostics;
using System.Management;

namespace SystemInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check system resources
            Console.WriteLine("System Resources:");
            Console.WriteLine("-----------------");
            Console.WriteLine("Total Space: {0} GB", GetTotalDiskSpace());
            Console.WriteLine("Available Space: {0} GB", GetAvailableDiskSpace());
            Console.WriteLine("Total Memory: {0} GB", GetTotalMemory());
            Console.WriteLine("Available Memory: {0} GB", GetAvailableMemory());
            Console.WriteLine("CPU Usage: {0}%", GetCpuUsage());

            // Check if Docker is installed
            Console.WriteLine("\nDocker:");
            Console.WriteLine("-------");
            if (IsDockerInstalled())
            {
                Console.WriteLine("Docker is installed.");
            }
            else
            {
                Console.WriteLine("Docker is not installed.");
            }

            // Check if chroot is active
            Console.WriteLine("\nchroot:");
            Console.WriteLine("-------");
            if (IsChrootActive())
            {
                Console.WriteLine("chroot is active.");
            }
            else
            {
                Console.WriteLine("chroot is not active.");
            }

            // List system users
            Console.WriteLine("\nSystem Users:");
            Console.WriteLine("-------------");
            ListSystemUsers();
        }

        // Get total disk space in GB
        static double GetTotalDiskSpace()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    double totalSpace = drive.TotalSize / (1024.0 * 1024 * 1024);
                    return Math.Round(totalSpace, 2);
                }
            }
            return 0;
        }

        // Get available disk space in GB
        static double GetAvailableDiskSpace()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    double availableSpace = drive.AvailableFreeSpace / (1024.0 * 1024 * 1024);
                    return Math.Round(availableSpace, 2);
                }
            }
            return 0;
        }

        // Get total memory in GB
        static double GetTotalMemory()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT TotalPhysicalMemory FROM Win32_ComputerSystem");
            foreach (ManagementObject obj in searcher.Get())
            {
                ulong totalMemoryBytes = Convert.ToUInt64(obj["TotalPhysicalMemory"]);
                double totalMemoryGB = totalMemoryBytes / (1024.0 * 1024 * 1024);
                return Math.Round(totalMemoryGB, 2);
            }
            return 0;
        }

        // Get available memory in GB
        static double GetAvailableMemory()
        {
            PerformanceCounter counter = new PerformanceCounter("Memory", "Available Bytes");
            double availableMemoryBytes = counter.NextValue();
            double availableMemoryGB = availableMemoryBytes / (1024.0 * 1024 * 1024);
            return Math.Round(availableMemoryGB, 2);
        }

        // Get CPU usage percentage
        static double GetCpuUsage()
        {
            PerformanceCounter counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            double cpuUsage = counter.NextValue();
            System.Threading.Thread.Sleep(1000);
            cpuUsage = counter.NextValue();
            return Math.Round(cpuUsage, 2);
        }

        // Check if Docker is installed
        static bool IsDockerInstalled()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "docker";
                process.StartInfo.Arguments = "--version";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                process.WaitForExit();

                return process.ExitCode == 0;
            }
        }

        // Check if chroot is active
        static bool IsChrootActive()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "mount";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                return output.Contains("chroot");
            }
        }

        // List system users
        static void ListSystemUsers()
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "wmic";
                process.StartInfo.Arguments = "useraccount list full";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                Console.WriteLine(output);
            }
        }
    }
}
