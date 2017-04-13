namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var zones = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToArray(); ;
            var checkpointIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                var currentDriver = drivers[i];
                decimal startingFuel = currentDriver[0];
                decimal fuel = startingFuel;
                var reachedZone = 0;
                var isCheckpoint = false;

                for (int j = 0; j < zones.Length; j++)
                {
                    for (int k = 0; k < checkpointIndexes.Length; k++)
                    {
                        if (j == checkpointIndexes[k])
                        {
                            isCheckpoint = true;
                            break;
                        }
                        else isCheckpoint = false;
                    }

                    if (isCheckpoint)
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                        if (fuel <= 0)
                        {
                            fuel = 0;
                            reachedZone = j;
                            break;
                        }
                    }
                }

                if (fuel == 0)
                {
                    Console.WriteLine($"{drivers[i]} - reached {reachedZone}");
                }
                else Console.WriteLine($"{drivers[i]} - fuel left {fuel:F2}");

            }
        }
    }
}
