namespace _02.CountOfNegativeElementsInArray
{
    using System;
    using System.Linq;
    public class CountOfNegativeElementsInArray
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (arrayOfNumbers[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
