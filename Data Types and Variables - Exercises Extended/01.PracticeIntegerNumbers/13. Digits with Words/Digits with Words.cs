using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Digits_with_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordDigit = Console.ReadLine().ToLower();

            switch (wordDigit)
            {
                case "zero":
                    Console.WriteLine(0);
                    return;
                case "one":
                    Console.WriteLine(1);
                    return;
                case "two":
                    Console.WriteLine(2);
                    return;
                case "three":
                    Console.WriteLine(3);
                    return;
                case "four":
                    Console.WriteLine(4);
                    return;
                case "five":
                    Console.WriteLine(5);
                    return;
                case "six":
                    Console.WriteLine(6);
                    return;
                case "seven":
                    Console.WriteLine(7);
                    return;
                case "eight":
                    Console.WriteLine(8);
                    return;
                case "nine":
                    Console.WriteLine(9);
                    return;
            }

        }
    }
}
