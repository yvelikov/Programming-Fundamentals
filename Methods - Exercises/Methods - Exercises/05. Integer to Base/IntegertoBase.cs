using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Integer_to_Base
{
    class IntegertoBase
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int tobase = int.Parse(Console.ReadLine());
            string result = IntegerToBase(number, tobase);
            Console.WriteLine(result);
        }
        static string IntegerToBase(long number, int toBase)
        {
            string result = string.Empty;
            
            long remainder = 0;
            while (number > 0)
            {
                remainder = number % toBase;
                result = remainder + result;
                number /= toBase;

            }
            return result;
        }

    }
}
