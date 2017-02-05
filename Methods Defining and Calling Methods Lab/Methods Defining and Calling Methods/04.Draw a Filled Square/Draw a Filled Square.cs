using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFilledSquare(n);
        }
        static void PrintFilledSquare(int n)
        {
            PrintHeader(n);

            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }
            
            PrintHeader(n);
        }
        static void PrintHeader(int n)
        {
            Console.WriteLine("{0}",new string('-',n*2));
        }
        static void PrintBody(int n)
        {
            string body = "-";
            for (int i = 0; i < n - 1; i++)
            {
                body += @"\/";
            }
            body += "-";
            Console.WriteLine(body);

        }
    }
}
