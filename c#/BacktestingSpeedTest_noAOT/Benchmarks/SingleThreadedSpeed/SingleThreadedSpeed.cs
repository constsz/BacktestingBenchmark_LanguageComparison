using System;

namespace BacktestingSpeedTest.Benchmarks.SingleThreadedSpeed;

public static class SingleThreadedSpeed
{
    public static void Run(int numberOfIterations, int meanWindow)
    {

        // Initialize Data Storage
        List<DataBox> data = new(numberOfIterations);

        // Generate data for specified number of iterations
        for (int i = 0; i < numberOfIterations; i++)
        {   
            // Main Values
            double a = (double)i;
            double b = (double)i * 0.75 + 1;
            double c = (a + b) / 2;
            double mean = 0d;

            if (i > 5)
            {
                c = (data[i - 5].A + data[i - 5].B) / 2;
            }

            
            // Calculate Moving Average
            if (i >= meanWindow) {
                
                double sum = 0.0;
                int startIndex = i - meanWindow;
                for (int j = startIndex; j < startIndex + meanWindow; j++)
                {
                    sum += data[j].C;
                }
                
                mean = sum / meanWindow;
            
            };

            DataBox box = new()
            {
                A = a,
                B = b,
                C = c,
                Mean = mean,
            };

            data.Add(box);

        }

        Console.WriteLine(data[numberOfIterations-1].Mean);

        //for (int i = 0; i < numberOfIterations; i++)
        //{
        //    Console.WriteLine($"{i}: {data[i].A} {data[i].B} {data[i].C} {data[i].Mean}");
            
        //    //Console.Write($"{data[i].Mean}, ");
        //}

    }
}


internal struct DataBox
{
    public double A;
    public double B;
    public double C;
    public double Mean;
}