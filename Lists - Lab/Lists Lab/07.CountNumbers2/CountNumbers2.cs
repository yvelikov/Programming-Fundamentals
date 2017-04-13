namespace _07.CountNumbers2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers2
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            inputNumbers.Sort();
            int count = 1;
            
            for (int i = 0; i < inputNumbers.Count-1; i++)
            {
                if (inputNumbers[i] == inputNumbers[i + 1])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{inputNumbers[i]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{inputNumbers[inputNumbers.Count-1]} -> {count}");

        }
    }
}
