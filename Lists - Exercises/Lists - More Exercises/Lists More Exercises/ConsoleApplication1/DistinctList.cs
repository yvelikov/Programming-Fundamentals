namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DistinctList
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int max = inputNumbers.Max();

            var sortedNumbers = new List<int>();
            foreach (var number in inputNumbers)
            {
                sortedNumbers.Add(number);
            }
            sortedNumbers.Sort();

            var repeatingNumbers = new List<int>();

            for (int i = 0; i < sortedNumbers.Count-1; i++)
            {
                if (sortedNumbers[i] == sortedNumbers[i + 1])
                {
                    if (!repeatingNumbers.Contains(sortedNumbers[i]))
                    {
                        repeatingNumbers.Add(sortedNumbers[i]);
                    }
                    
                }
            }

            var result = new List<int>();
            for (int i = 0; i < inputNumbers.Count; i++)
            {
                for (int j = 0; j < repeatingNumbers.Count; j++)
                {
                    if (inputNumbers[i] != repeatingNumbers[j])
                    {
                        if (!result.Contains(inputNumbers[i]))
                        {
                            result.Add(inputNumbers[i]);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",result));
           
        }
    }
}
