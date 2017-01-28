using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                char currentChar = (char)num;
                output += currentChar;
            }
            Console.WriteLine(output);
        }
    }
}
