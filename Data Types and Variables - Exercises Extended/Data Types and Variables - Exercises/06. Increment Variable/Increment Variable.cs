using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int increment = int.Parse(Console.ReadLine());
            byte counter = 0;
            int overflow = 0;

            for (int i = 0; i < increment; i++)
            {
                counter++;
                if (counter == 0)
                {
                    
                    overflow += 1;
                }
                
                
            }
            Console.WriteLine(counter);
            if (overflow>0)
            Console.WriteLine($"Overflowed {overflow} times");



        }
    }
}
