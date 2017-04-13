namespace _04.SortArrayUsingBubbleSort
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

            bool swapped = false;

            do
            {
                swapped = false;

                for (int i = 0; i < inputNumbers.Count - 1; i++)
                {
                    if (inputNumbers[i] > inputNumbers[i + 1])
                    {
                        int temp = inputNumbers[i];
                        inputNumbers[i] = inputNumbers[i + 1];
                        inputNumbers[i + 1] = temp;
                        swapped = true;
                    }
                }
            }
            while (swapped);

            Console.WriteLine(string.Join(" ", inputNumbers));

        }
    }
}
