using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            bool isValid = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
            if (isValid)
            {
                Console.WriteLine("Triangle is valid.");
                if (sideA * sideA + sideB * sideB == sideC * sideC)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                }
                else if (sideA * sideA + sideC * sideC == sideB * sideB)
                {
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                }
                else if (sideC * sideC + sideB * sideB == sideA * sideA)
                {
                    Console.WriteLine("Triangle has a right angle between sides c and b");
                }
                else Console.WriteLine("Triangle has no right angles");
            }
            else Console.WriteLine("Invalid triangle.");

            

            


        }
    }
}
