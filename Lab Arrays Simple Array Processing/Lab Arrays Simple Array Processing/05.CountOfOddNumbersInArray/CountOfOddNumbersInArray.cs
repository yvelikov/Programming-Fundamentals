namespace _05.CountOfOddNumbersInArray
{
    using System;
    using System.Linq;

    class CountOfOddNumbersInArray
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    count++;
                }

            }
            Console.WriteLine(count);
        }
    }
}
