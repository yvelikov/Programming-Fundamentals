﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 0;

            Console.WriteLine("Before:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            c = a;
            a = b;
            b = c;

            Console.WriteLine("After:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
