namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OddOccurrences
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new Dictionary<string, int>();

            foreach (var word in sequence)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            var oddValues = new List<string>();

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    oddValues.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ",oddValues));
        }
    }
}
