

namespace _01.MultEvensByOdds
{
    using System;
    class MultEvensByOdds
    {

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(result);
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int digit = 0;
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digit = number % 10;

                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
                
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int digit = 0;
            int sum = 0;
            number = Math.Abs(number);
            while (number > 0)
            {
                digit = number % 10;

                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;

            }
            return sum;
        }
    }
}
