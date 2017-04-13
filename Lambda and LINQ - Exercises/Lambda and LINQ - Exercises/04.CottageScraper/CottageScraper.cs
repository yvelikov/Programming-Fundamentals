namespace _04.CottageScraper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CottageScraper
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            var trees = new Dictionary<string, List<int>>();

            while (inputString != "chop chop")
            {
                var treeParams = inputString.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var type = treeParams[0];
                var height = int.Parse(treeParams[1]);

                if (!trees.ContainsKey(type))
                {
                    trees[type] = new List<int>();
                }
                trees[type].Add(height);
                

                inputString = Console.ReadLine();
            }

            var typeToUse = Console.ReadLine();
            var minLenght = int.Parse(Console.ReadLine());

            var treesToUse = FilterTreesToUse(trees,typeToUse,minLenght);

            var logs = trees.SelectMany(x => x.Value);

            decimal pricePerMeter = (decimal)logs.Average();
            pricePerMeter = Math.Round(pricePerMeter, 2);
            
            var usedLogs = treesToUse.SelectMany(x => x.Value);
            var usedLogPrice = usedLogs.Sum()*pricePerMeter;
            usedLogPrice = Math.Round(usedLogPrice, 2);

            var unusedLogs = FilterUnusedTrees(trees, typeToUse, minLenght);

            var unusedLogsPrice = unusedLogs.Sum()*pricePerMeter*0.25m;
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);


            foreach (var tree in treesToUse)
            {
                Console.WriteLine("Price per meter: ${0:f2}",pricePerMeter);
                Console.WriteLine("Used logs price: ${0:f2}",usedLogPrice);
                Console.WriteLine("Unused logs price: ${0:f2}",unusedLogsPrice);
                Console.WriteLine("CottageScraper subtotal: ${0:f2}", usedLogPrice+unusedLogsPrice);
            }
            
        }

        public static List<int> FilterUnusedTrees(Dictionary<string, List<int>> trees, string typeToUse, int minLenght)
        {
            var unusedTrees = trees
                .ToDictionary(x => x.Key, x => x.Value);

            var uselessLogs = new List<int>();

            foreach (var tree in unusedTrees)
            {
                foreach (var length in tree.Value)
                {
                    if (tree.Key != typeToUse || length < minLenght )
                    {
                        uselessLogs.Add(length);
                    }
                }
            }

            return uselessLogs;
        }

        public static Dictionary<string,List<int>> FilterTreesToUse(Dictionary<string, List<int>> trees, string typeToUse, int minLenght)
        {
            var treesToUse = trees
                .Where(x => x.Key == typeToUse)
                .ToDictionary(x => x.Key, x => x.Value);

            var logsToUse = new List<int>();

            foreach (var tree in treesToUse)
            {
                foreach (var length in tree.Value)
                {
                    if (length >= minLenght)
                    {
                        logsToUse.Add(length);
                    }
                }
            }

            treesToUse = treesToUse
                .ToDictionary(x => x.Key, x => logsToUse);

            return treesToUse;
        }
    }
}
