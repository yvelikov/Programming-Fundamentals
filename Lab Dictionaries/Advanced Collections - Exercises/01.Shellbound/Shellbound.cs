namespace _01.Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var command = Console.ReadLine().Split();

            var shellRegionsAndSizes = new Dictionary<string, HashSet<int>>();

            while (command[0] != "Aggregate")
            {
                var region = command[0];
                var size = int.Parse(command[1]);

                if (!shellRegionsAndSizes.ContainsKey(region))
                {
                    shellRegionsAndSizes[region] = new HashSet<int>();
                }
                shellRegionsAndSizes[region].Add(size);

                command = Console.ReadLine().Split();
            }

            foreach (var region in shellRegionsAndSizes)
            {
                var sum = 0;
                Console.Write($"{region.Key} -> ");
                Console.Write(string.Join(", ", region.Value));
                foreach (var size in region.Value)
                {
                    sum += size;
                }
                Console.WriteLine($" ({sum - sum/region.Value.Count})");
            }
        }
    }
}
