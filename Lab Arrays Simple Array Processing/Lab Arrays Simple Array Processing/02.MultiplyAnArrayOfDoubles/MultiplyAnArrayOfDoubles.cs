
namespace _02.MultiplyAnArrayOfDoubles
{
    using System;
    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            string numbers = Console.ReadLine();
            string[] items = numbers.Split(' ');

            double[] arrayOfNumbers = new double[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arrayOfNumbers[i] = double.Parse(items[i]);
            }

            double multiplicator = double.Parse(Console.ReadLine());

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] *= multiplicator;
            }

            string result = string.Join(" ", arrayOfNumbers);
            Console.WriteLine(result);
          
        }
    }
}
