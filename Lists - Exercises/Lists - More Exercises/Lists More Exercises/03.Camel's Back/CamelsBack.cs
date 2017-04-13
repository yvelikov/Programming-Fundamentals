namespace _03.Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int size = int.Parse(Console.ReadLine());

            int buildings = inputNumbers.Count;
            int rounds = 0;
            while (buildings > size)
            {
                inputNumbers.RemoveAt(0);
                inputNumbers.RemoveAt(inputNumbers.Count - 1);
                rounds++;
            }

            Console.WriteLine($"rounds: {rounds}");



        }
    }
}
