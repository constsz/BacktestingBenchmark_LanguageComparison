using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BacktestingSpeedTest.Benchmarks.SingleThreadedSpeed;

namespace BacktestingSpeedTestFramework48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Process currentProcess = Process.GetCurrentProcess();

            SingleThreadedSpeed.Run(256_000_000, 250);

            stopwatch.Stop();

            long memoryUsed = currentProcess.PeakWorkingSet64 / 1024 / 1024; // Convert to MB

            Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Peak Memory Usage: {memoryUsed} MB");


            Console.ReadLine();
        }
    }
}
