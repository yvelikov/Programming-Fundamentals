using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    class CottageScraper
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var dictionary = new Dictionary<string, List<decimal>>();
            decimal usedLogsCount = 0m;
            decimal unusedLogsCount = 0m;
            decimal pricePerMeter = 0m;

            while (!input.Equals("chop chop"))
            {

                if (!input.Equals("chop chop"))
                {
                    var dateLine = input.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    var type = dateLine[0];
                    var height = decimal.Parse(dateLine[1]);

                    if (!dictionary.ContainsKey(type))
                    {
                        dictionary[type] = new List<decimal>();
                    }
                    dictionary[type].Add(height);
                }

                input = Console.ReadLine();
            }

            var typeOfThree = Console.ReadLine();
            var minimumLenght = decimal.Parse(Console.ReadLine());

           
                var usedLogs = dictionary
                     .Where(x => x.Key == typeOfThree)
                     .SelectMany(x => x.Value.Where(y => y >= minimumLenght))
                     .ToList();

                var unusedLogsLessLenght = dictionary
                     .Where(x => x.Key == typeOfThree)
                     .SelectMany(x => x.Value.Where(y => y < minimumLenght))
                     .ToList();

                var unusedLogs = dictionary
                     .Where(x => x.Key != typeOfThree)
                     .SelectMany(x => x.Value)
                     .ToList();

                usedLogsCount = usedLogs.Sum();
                unusedLogsCount = unusedLogsLessLenght.Sum() + unusedLogs.Sum();

                var logs = dictionary.SelectMany(x => x.Value);
                pricePerMeter = Math.Round(logs.Average(), 2);
            

            var usedLogsPrice = usedLogsCount * pricePerMeter;
            usedLogsPrice = Math.Round(usedLogsPrice, 2);
            var unusedLogsPrice = unusedLogsCount * pricePerMeter * 0.25m;
            unusedLogsPrice = Math.Round(unusedLogsPrice, 2);
            var cottageScraperSubtotal = usedLogsPrice + unusedLogsPrice;
            cottageScraperSubtotal = Math.Round(cottageScraperSubtotal, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${cottageScraperSubtotal:F2}");
        }
    }
}