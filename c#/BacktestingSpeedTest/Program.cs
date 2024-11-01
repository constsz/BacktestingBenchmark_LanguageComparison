using BacktestingSpeedTest.Benchmarks.SingleThreadedSpeed;
using System;
using System.Diagnostics;

Stopwatch stopwatch = Stopwatch.StartNew();
Process currentProcess = Process.GetCurrentProcess();

SingleThreadedSpeed.Run(256_000_000, 250);

stopwatch.Stop();
long memoryUsed = currentProcess.PeakWorkingSet64 / 1024 / 1024; // Convert to MB

Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
Console.WriteLine($"Peak Memory Usage: {memoryUsed} MB");


Console.ReadLine();