using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nth_Digit
{
    class NthDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            int nthDigit = FindNthDigit(number, index);

            Console.WriteLine(nthDigit);
        }
        static int FindNthDigit(int number, int index)
        {
            int count = 0;
            int result = 0;
            int currentNumber = 1;
            int indexNumber = 1;
            while (currentNumber > 0)
            {
                currentNumber = number;
                result = number % 10;
                count++;
                if (count == index)
                {
                    indexNumber = result;
                }
                number = number / 10;



            }
            return indexNumber;

        }
    }
}
