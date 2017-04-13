namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class CottageScraper
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var trees = new Dictionary<string, List<int>>();

            while (entry != "chop chop")
            {
                var treeParams = entry.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var treeType = treeParams[0];
                var treeLength = int.Parse(treeParams[1]);

                if (!trees.ContainsKey(treeType))
                {
                    trees[treeType] = new List<int>();
                }
                trees[treeType].Add(treeLength);

                entry = Console.ReadLine();
            }

            var typeToUse = Console.ReadLine();
            var minLenght = int.Parse(Console.ReadLine());

            var treesToUse = trees
                .Where(x => x.Key == typeToUse)
                .SelectMany(x => x.Value)
                .Where(x => x >= minLenght)
                .Sum();

            var pricePerMeter = trees
                .SelectMany(x => x.Value)
                .Average();
            pricePerMeter = Math.Round(pricePerMeter, 2);

            var unusedLogsByType = trees
                .Where(x => x.Key != typeToUse)
                .SelectMany(x => x.Value)
                .Sum();

            var unusedLogsByLength = trees
                .Where(x => x.Key == typeToUse)
                .SelectMany(x => x.Value)
                .Where(x => x < minLenght)
                .Sum();

            var unusedLogsPrice = (unusedLogsByLength + unusedLogsByType)*pricePerMeter*0.25;
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
            var usedLogsPrice = treesToUse * pricePerMeter;
            usedLogsPrice = Math.Round(usedLogsPrice, 2);
            var total = unusedLogsPrice + usedLogsPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${total:F2}");
        }
    }
}
