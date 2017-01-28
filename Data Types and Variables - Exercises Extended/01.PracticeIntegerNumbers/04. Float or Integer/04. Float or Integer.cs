using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            bool isInteger = num1 % 1 == 0;
            if (isInteger)
            {
                Console.WriteLine(num1);
            }
            else Console.WriteLine(Math.Round(num1));
        }
    }
}
