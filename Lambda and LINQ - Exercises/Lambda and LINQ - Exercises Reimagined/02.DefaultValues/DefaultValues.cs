namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var keyValuePairs = new Dictionary<string, string>();

            while (entry != "end")
            {
                var entryParams = entry.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var key = entryParams[0];
                var value = entryParams[1];

                keyValuePairs[key] = value;

                entry = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var notReplacedValues = keyValuePairs
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in notReplacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            var replacedValues = keyValuePairs
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var kvp in replacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }
        }
    }
}
