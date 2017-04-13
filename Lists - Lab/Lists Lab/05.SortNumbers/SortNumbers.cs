namespace _05.SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

            listOfNumbers.Sort();

            Console.WriteLine(string.Join(" <= ",listOfNumbers));
        }
    }
}
