namespace _07.LargestNElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNElements
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                var inserted = false;
                var currentElement = inputNumbers[i];
                for (int j = 0; j < result.Count; j++)
                {
                    var currentListElement = result[j];
                    if (currentElement >= currentListElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0,j),currentElement);
                        break;
                    }
                }
                if (!inserted)
                {
                    result.Add(currentElement);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(result[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
