﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 1;

            c = a;
            a = b;
            b = c;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
