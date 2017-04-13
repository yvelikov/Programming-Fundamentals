using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }
        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
