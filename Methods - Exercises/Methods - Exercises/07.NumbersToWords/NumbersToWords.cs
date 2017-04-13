using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersToWords
{
    class NumbersToWords
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                int typeOfnumber = DefineNumber(number);

                if (number > 999)
                {
                    Console.WriteLine("too large");
                }
                else if (number < -999)
                {
                    Console.WriteLine("too small");
                }
                else if (typeOfnumber == 2 || typeOfnumber == 1)
                {
                    continue;
                }
                else
                {
                    string letterizedNumber = Letterize(number);
                    Console.WriteLine(letterizedNumber);
                }

            }
        }
        static string Letterize(int number)
        {
            string letterizedNumber = string.Empty;
            int firstDigit = (Math.Abs(number) / 100) % 10;
            int secondDigit = (Math.Abs(number) / 10) % 10;
            int thirdDigit = Math.Abs(number) % 10;
            string hundreds = GetLetterizedDigit(firstDigit);
            string tens = GetLetterizedTens(secondDigit);
            string ones = GetLetterizedDigit(thirdDigit);
            string teens = GetLetterizedTeens(thirdDigit);
            string sign = DefineSign(number);

            if (secondDigit == 0 && thirdDigit == 0)
            {
                letterizedNumber = $"{sign}{hundreds}-hundred";
                return letterizedNumber;
            }
            else if (secondDigit == 0 && thirdDigit != 0)
            {
                letterizedNumber = $"{sign}{hundreds}-hundred and {ones}";
                return letterizedNumber;
            }
            else if (secondDigit == 1)
            {
                letterizedNumber = $"{sign}{hundreds}-hundred and {teens}";
                return letterizedNumber;
            }
            else
            {
                letterizedNumber = $"{sign}{hundreds}-hundred and {tens} {ones}";
                return letterizedNumber;
            }
               
            
        }

        static int DefineNumber(int number)
        {
            int count = 1;
            if (number > 0)
            {
                while (number >= 10)
                {
                    number /= 10;
                    count++;
                }
            }
            else
                while (Math.Abs(number) >= 10)
                {
                    number /= 10;
                    count++;
                }

            return count;
        }

        static string DefineSign(int number)
        {
            string sign = string.Empty;
            if (number > 0)
            {
                return sign;
            }
            else return sign = "minus ";
        }

        static string GetLetterizedDigit(int digit)
        {
            string letterizedDigit = string.Empty;

            switch (digit)
            {
                case 1:
                    letterizedDigit = "one";
                    break;
                case 2:
                    letterizedDigit = "two";
                    break;
                case 3:
                    letterizedDigit = "three";
                    break;
                case 4:
                    letterizedDigit = "four";
                    break;
                case 5:
                    letterizedDigit = "five";
                    break;
                case 6:
                    letterizedDigit = "six";
                    break;
                case 7:
                    letterizedDigit = "seven";
                    break;
                case 8:
                    letterizedDigit = "eight";
                    break;
                case 9:
                    letterizedDigit = "nine";
                    break;
            }
                
            return letterizedDigit;
        }

        static string GetLetterizedTens(int digit)
        {
            string letterizedDigit = string.Empty;

            switch (digit)
            {
                case 1:
                    letterizedDigit = "one";
                    break;
                case 2:
                    letterizedDigit = "twenty";
                    break;
                case 3:
                    letterizedDigit = "thirty";
                    break;
                case 4:
                    letterizedDigit = "forty";
                    break;
                case 5:
                    letterizedDigit = "fifty";
                    break;
                case 6:
                    letterizedDigit = "sixty";
                    break;
                case 7:
                    letterizedDigit = "seventy";
                    break;
                case 8:
                    letterizedDigit = "eighty";
                    break;
                case 9:
                    letterizedDigit = "ninety";
                    break;
            }

            return letterizedDigit;

        }

        static string GetLetterizedTeens(int digit)
        {
            string letterizedDigit = string.Empty;

            switch (digit)
            {
                case 0:
                    letterizedDigit = "ten";
                    break;
                case 1:
                    letterizedDigit = "eleven";
                    break;
                case 2:
                    letterizedDigit = "twelve";
                    break;
                case 3:
                    letterizedDigit = "thirteen";
                    break;
                case 4:
                    letterizedDigit = "fourteen";
                    break;
                case 5:
                    letterizedDigit = "fifteen";
                    break;
                case 6:
                    letterizedDigit = "sixteen";
                    break;
                case 7:
                    letterizedDigit = "seventeen";
                    break;
                case 8:
                    letterizedDigit = "eighteen";
                    break;
                case 9:
                    letterizedDigit = "nineteen";
                    break;
            }

            return letterizedDigit;

        }
    }
}
