namespace _03.ReverseArrayInPlace
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
                .ToList();

            int length = inputNumbers.Count;

            for (int i = 0; i < length / 2; i++)
            {
                int currentNumber = inputNumbers[i];
                inputNumbers[i] = inputNumbers[length - i - 1];
                inputNumbers[length - i - 1] = currentNumber;
            }

            Console.WriteLine(string.Join(" ",inputNumbers));

        }
    }
}
