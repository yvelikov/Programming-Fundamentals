namespace _03.FlattenDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlattenDictionary
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, string>>();

            while (entry != "end")
            {
                var entryParams = entry.Split(' ');

                if (entryParams[0] != "flatten")
                {
                    var key = entryParams[0];
                    var innerKey = entryParams[1];
                    var innerValue = entryParams[2];

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new Dictionary<string, string>();
                    }
                    dictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var keyToFlatten = entryParams[1];
                    dictionary[keyToFlatten] = dictionary[keyToFlatten].ToDictionary(x => x.Key + x.Value, x => "flattened");
                }

                entry = Console.ReadLine();
            }

            dictionary = dictionary
                .OrderByDescending(x => x.Key.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var input in dictionary)
            {
                Console.WriteLine($"{input.Key}");
                var nonFlattenedKyes = input.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x=> x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);

                var count = 1;
                foreach (var innerKey in nonFlattenedKyes)
                {
                    Console.WriteLine($"{count}. {innerKey.Key} - {innerKey.Value}");
                    count++;
                }

                var flattenedKyes = input.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var flattenedKey in flattenedKyes)
                {
                    Console.WriteLine($"{count}. {flattenedKey.Key}");
                    count++;
                }
            }
        }
    }
}
