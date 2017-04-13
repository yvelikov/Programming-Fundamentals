namespace _06.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            foreach (var number in listOfNumbers)
            {
                var squareNumber = Math.Sqrt(number);
                if (squareNumber % 1 == 0)
                {
                    result.Add(number);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ",result));
            
        }
    }
}
