using System;
using System.Collections.Generic;
using System.Linq;


namespace _02.SmallestElementInArray
{
    public class SmallestElementInArray
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int min = int.MaxValue;

            for (int i = 0; i < inputNumbers.Count; i++)
            {
                if (inputNumbers[i] < min)
                {
                    min = inputNumbers[i];
                }
            }

            Console.WriteLine(min);
        }
    }
}
