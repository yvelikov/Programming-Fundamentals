namespace _05.SortArrayUsingInsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < inputNumbers.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (inputNumbers[j] < inputNumbers[j - 1])
                    {
                        int currentNumber = inputNumbers[j];
                        inputNumbers[j] = inputNumbers[j - 1];
                        inputNumbers[j - 1] = currentNumber;
                    }
                    j--;
                }
            }

            Console.WriteLine(string.Join(" ",inputNumbers));


        }
    }
}
