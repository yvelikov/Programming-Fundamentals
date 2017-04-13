namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

        }
    }
}
