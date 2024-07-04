using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("~ checking for roblox ~");

        while (true)
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            if (processes.Length > 0)
            {
                Console.Clear();
                Console.WriteLine("ROBLOX FOUND!");

                Thread.Sleep(500);

                foreach (var process in processes)
                {
                    process.Kill();
                }

                Console.WriteLine("ROBLOX KILLED!");
                break;
            }

            Thread.Sleep(1000);
        }
    }
}
