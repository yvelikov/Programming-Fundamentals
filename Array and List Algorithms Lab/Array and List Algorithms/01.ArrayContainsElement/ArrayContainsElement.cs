namespace _01.ArrayContainsElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var inputNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var number = int.Parse(Console.ReadLine());

            bool isPresent = false;

            for (int i = 0; i < inputNumber.Count; i++)
            {
                if (number == inputNumber[i])
                {
                    isPresent = true;
                    break;
                }
            }

            if (isPresent)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");

        }
    }
}
