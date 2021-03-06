﻿namespace _04.FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var k = numbers.Length / 4;

            var upperLeftRow = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var upperRightRow = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var lowerRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var upperRow = upperLeftRow.Concat(upperRightRow).ToArray();

            var result = new int[upperRow.Length];

            for (int i = 0; i < upperRow.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
