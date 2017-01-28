using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            decimal numInTerabytes = (decimal)num * 1024m * 1024m * 1024m * 1024m * 8m;
            Console.WriteLine("{0:F0}",numInTerabytes);

        }
    }
}
