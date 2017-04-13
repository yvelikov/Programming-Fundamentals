namespace _01.MinMaxSumAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var listOfNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                listOfNumbers.Add(number);
            }

            Console.WriteLine("Sum = {0}", listOfNumbers.Sum());
            Console.WriteLine("Min = {0}", listOfNumbers.Min());
            Console.WriteLine("Max = {0}", listOfNumbers.Max());
            Console.WriteLine("Average = {0}", listOfNumbers.Average());
        }
    }
}
