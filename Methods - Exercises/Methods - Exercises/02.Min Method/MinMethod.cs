using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Min_Method
{
    class MinMethod
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int firstMinNumber = GetMin(firstNumber, secondNumber);
            int minNumber = GetMin(firstMinNumber, thirdNumber);
            Console.WriteLine(minNumber);
        }
        static int GetMin(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            return b;
           
        }
     

    }
}
