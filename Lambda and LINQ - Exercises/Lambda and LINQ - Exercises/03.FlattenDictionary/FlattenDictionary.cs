namespace _03.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, Dictionary<string, string>>();
            var flattenedDict = new Dictionary<string, Dictionary<string, string>>();

            while (entry[0] != "end")
            {
                if (entry[0] != "flatten")
                {
                    var key = entry[0];
                    var innerKey = entry[1];
                    var innerValue = entry[2];

                    if (!dict.ContainsKey(key))
                    {
                        dict[key] = new Dictionary<string, string>();
                    }

                    if (!dict[key].ContainsKey(innerKey))
                    {
                        dict[key][innerKey] = innerValue;
                    }
                    dict[key][innerKey] = innerValue;
                }
                else
                {
                    var keyToFlatten = entry[1];
                    dict[keyToFlatten] = dict[keyToFlatten].ToDictionary(k => k.Key + k.Value, v => "flattended");

                }
                entry = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            var dictToPrint = dict
                .OrderByDescending(k => k.Key.Length)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var outerKey in dictToPrint)
            {
                var count = 1;
                Console.WriteLine($"{outerKey.Key}");

                var orderedInnerDict = outerKey.Value
                    .Where(k => k.Value != "flattended")
                    .OrderBy(k => k.Key.Length)
                    .ToDictionary(k => k.Key, v => v.Value);

                var flattenedInnerDict = outerKey.Value
                    .Where(k => k.Value == "flattended")
                    .ToDictionary(k => k.Key, v => v.Value);

                foreach (var kvp in orderedInnerDict)
                {
                    Console.WriteLine($"{count}. {kvp.Key} - {kvp.Value}");
                    count++;
                }
                foreach (var kvp in flattenedInnerDict)
                {
                    Console.WriteLine($"{count}. {kvp.Key}");
                    count++;
                }
            }
        }
    }
}
