namespace _01.ConvertFromBase10ToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(' ');

            var baseN = BigInteger.Parse(line[0]);
            var baseTenNumber = BigInteger.Parse(line[1]);
            
            var result = new List<BigInteger>();

            while (baseTenNumber > 0 )
            {
                var currentNumber = baseTenNumber % baseN;
                baseTenNumber /= baseN;

                result.Add(currentNumber);
            }

            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
