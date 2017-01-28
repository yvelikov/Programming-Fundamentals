using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimiter = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            string output = "";
            string lastInput="";
            for (int i = 1; i <= numberOfLines; i++)
            {
                string text = Console.ReadLine();
                lastInput = text;
                if (i == numberOfLines)
                    break;
                output = output + text + delimiter;
                
            }
            Console.WriteLine(output+lastInput);
        }
    }
}
