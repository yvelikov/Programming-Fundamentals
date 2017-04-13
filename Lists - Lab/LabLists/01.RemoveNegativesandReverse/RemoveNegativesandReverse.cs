namespace _01.RemoveNegativesandReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class RemoveNegativesandReverse
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            foreach (var number in inputNumbers)
            {
                if (number > 0)
                {
                    result.Add(number);
                }

            }

            if (result.Count > 0)
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
            else Console.WriteLine("empty");
            
        }
    }
}
