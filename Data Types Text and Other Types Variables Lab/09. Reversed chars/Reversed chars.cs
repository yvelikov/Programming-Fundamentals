using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string current = null;
            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                current += letter;
            }
            for (int i = current.Length-1; i >= 0; i--)
            {
                Console.Write(current[i]);
            }
            
        }
    }
}
