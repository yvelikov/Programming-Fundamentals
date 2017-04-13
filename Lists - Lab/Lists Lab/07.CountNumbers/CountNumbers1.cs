namespace _07.CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers1
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int max = inputNumbers.Max();

            var counts = new int[max + 1];

            for (int i = 0; i <= max; i++)
            {
                foreach (var number in inputNumbers)
                {
                    if (number == i)
                    {
                        counts[i]++;
                    }
                }
            }

            
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                {
                    Console.WriteLine($"{i} -> {counts[i]}");
                }
            }
             

            
        }
    }
}
