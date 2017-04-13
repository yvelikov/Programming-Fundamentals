namespace _06.InsertionSortUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var result = new List<int>() {};

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                var inserted = false;
                var currentArrayElement = inputNumbers[i];
                for (int j = 0; j < result.Count; j++)
                {
                    var currentListElement = result[j];
                    if (currentArrayElement <= currentListElement)
                    {
                        inserted = true;
                        result.Insert(Math.Max(0, j),currentArrayElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    result.Add(currentArrayElement);
                }
            }

            Console.WriteLine(string.Join(" ",result));
           
        }
    }
}
