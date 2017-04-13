namespace _02.ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseNToBase10
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(' ');

            var baseN = BigInteger.Parse(line[0]);
            var numberToConvert = line[1];

            var reversedNumber = string.Empty;

            BigInteger result = 0;

            for (int i = 0; i < numberToConvert.Length; i++)
            {
                result += BigInteger.Parse(numberToConvert[numberToConvert.Length - 1 - i].ToString())*BigInteger.Pow(baseN,i);
            }

            Console.WriteLine(result);
        }
    }
}
