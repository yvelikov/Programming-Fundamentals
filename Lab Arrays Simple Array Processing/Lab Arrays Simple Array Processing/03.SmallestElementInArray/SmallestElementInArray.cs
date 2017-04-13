namespace _03.SmallestElementInArray
{
    using System;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split(' ');
            int[] arrayOfIntegers = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arrayOfIntegers[i] = int.Parse(items[i]);
            }

            int min = int.MaxValue;

            for (int i = 0; i < arrayOfIntegers.Length; i++)
            {
                if (arrayOfIntegers[i] < min)
                {
                    min = arrayOfIntegers[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
