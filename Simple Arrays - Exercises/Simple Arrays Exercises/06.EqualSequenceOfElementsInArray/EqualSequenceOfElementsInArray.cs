namespace _06.EqualSequenceOfElementsInArray
{
    using System;
    public class EqualSequenceOfElementsInArray
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int[] parsedNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < parsedNumbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
            }

            int count = 1;

            for (int i = parsedNumbers.Length - 1; i > 0; i--)
            {
                int element = parsedNumbers[i];
                if (element == parsedNumbers[i - 1])
                {
                    count++;
                }
            }

            if (count == parsedNumbers.Length)
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
