namespace _03.SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            decimal sum = 0;

            for (int i = 1; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] == inputNumbers[i - 1])
                {
                    sum = inputNumbers[i] + inputNumbers[i - 1];
                    inputNumbers[i] = sum;
                    inputNumbers.RemoveAt(i-1);
                    i = 0;
                }
            }
                
            Console.WriteLine(string.Join(" ",inputNumbers));
        }
    }
}
