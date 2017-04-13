using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            var capacities = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var usage = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var testHours = int.Parse(Console.ReadLine());

            var batteryStatus = new double [capacities.Length];
            for (int i = 0; i < batteryStatus.Length; i++)
            {
                batteryStatus[i] = capacities[i];
            }

            for (int i = 0; i < testHours; i++)
            {
                for (int j = 0; j < batteryStatus.Length; j++)
                {
                    batteryStatus[j] -= usage[j];
                }
            }

            for (int i = 0; i < batteryStatus.Length; i++)
            {
                if (batteryStatus[i] > 0)
                {
                    Console.WriteLine("Battery {0}: {1:F2} mAh ({2:F2})%", i + 1, batteryStatus[i], (100 * (batteryStatus[i] / capacities[i])));
                }
                else
                {
                    int count = 0;
                    for (int j = 0; j < testHours; j++)
                    {
                        if (capacities[i] > 0)
                        {
                            capacities[i] -= usage[i];
                            count++;
                        }
                        
                    }
                    Console.WriteLine("Battery {0}: dead (lasted {1} hours)",i+1,count);
                }
                
            }
            

        }
    }
}
