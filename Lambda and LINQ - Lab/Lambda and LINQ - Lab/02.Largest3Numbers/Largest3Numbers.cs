namespace _02.Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers = numbers
                .OrderByDescending(n => n)
                .Take(3)
                .ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
