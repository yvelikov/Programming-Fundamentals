namespace _01.RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    result.Add(numbers[i]);
                }

                
            }

            
            result.Reverse();

            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else Console.WriteLine("empty");
        }
    }
}
