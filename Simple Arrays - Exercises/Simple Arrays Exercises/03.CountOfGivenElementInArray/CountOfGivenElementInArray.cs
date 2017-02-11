namespace _03.CountOfGivenElementInArray
{
    using System;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int element = int.Parse(Console.ReadLine());
            int[] parsedNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
            }

            int count = 0;

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                if (parsedNumbers[i] == element)
                    count++;

            }
            Console.WriteLine(count);
        }
    }
}
