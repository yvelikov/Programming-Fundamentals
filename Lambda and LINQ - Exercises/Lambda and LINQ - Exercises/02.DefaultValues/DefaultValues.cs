namespace _02.DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            var keyValuePairs = new Dictionary<string, string>();

            while (entry[0]!="end")
            {
                var key = entry[0];
                var value = entry[1];

                if (!keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key] = value;
                }
                keyValuePairs[key] = value;

                entry = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var defaultValue = Console.ReadLine();

            var nonReplacedValues = keyValuePairs
                .Where(v => v.Value != "null")
                .OrderByDescending(v => v.Value.Length)
                .ToDictionary(k => k.Key, v => v.Value );

            foreach (var kvp in nonReplacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
            }

            var replacedValues = keyValuePairs
                .Where(v => v.Value == "null")
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var kvp in replacedValues)
            {
                Console.WriteLine($"{kvp.Key} <-> {defaultValue}");
            }

        }
    }
}
