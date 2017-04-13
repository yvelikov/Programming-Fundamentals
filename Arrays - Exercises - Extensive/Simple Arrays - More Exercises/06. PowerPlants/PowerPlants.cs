
namespace _06.PowerPlants
{
    using System;

    class PowerPlants
    {
        static void Main(string[] args)
        {
            string[] powerLevel = Console.ReadLine().Split(' ');
            int[] parsedPowerLevel = new int[powerLevel.Length];

            for (int i = 0; i < parsedPowerLevel.Length; i++)
            {
                parsedPowerLevel[i] = int.Parse(powerLevel[i]);
            }

            int day = 0;
            int max = int.MinValue;
            int index = 0;

            for (int i = 0; i < parsedPowerLevel.Length; i++)
            {
                if (parsedPowerLevel[i] > max)
                {
                    index = i;
                    max = parsedPowerLevel[i];
                }
            }

            int totalDays = 0;
            int alive = 0;
            int count = 0;

            while (parsedPowerLevel[index] != 0)
            {
                if (count > 0 && day == 0)
                {
                    alive++;
                }
                for (int i = 0; i < parsedPowerLevel.Length; i++)
                {
                    if (i != day)
                    {
                        if (parsedPowerLevel[i] > 0)
                        {
                            parsedPowerLevel[i] -= 1;
                        }
                    }
                }

                day++;
                totalDays++;

                if (day == parsedPowerLevel.Length)
                {
                    day = 0;
                    for (int i = 0; i < parsedPowerLevel.Length; i++)
                    {
                        if (parsedPowerLevel[i] > 0)
                        {
                            parsedPowerLevel[i] +=1;
                        }
                    }
                    count++;
                }
            }

            if (alive == 1)
            {
                Console.WriteLine($"survived {totalDays} days ({alive} season)");
            }
            else Console.WriteLine($"survived {totalDays} days ({alive} seasons)");

        }
    }
}
