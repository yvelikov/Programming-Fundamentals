namespace _04.CountOccurOfLargerNumbersInArray
{
    using System;
    public class CountOccurOfLargerNumbersInArray
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            double element = double.Parse(Console.ReadLine());
            double[] parsedNumbers = new double[inputNumbers.Length];

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                parsedNumbers[i] = double.Parse(inputNumbers[i]);
            }

            int count = 0;

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                if (parsedNumbers[i] > element)
                    count++;
            }

            Console.WriteLine(count);

        }
    }
}
