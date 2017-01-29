using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                PrintTriangle(i);
            }
            for (int i = n-1; i > 0; i--)
            {
                PrintTriangle(i);
            }

        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
