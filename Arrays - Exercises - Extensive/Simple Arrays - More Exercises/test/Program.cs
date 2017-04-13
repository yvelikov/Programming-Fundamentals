using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "end")
            {
                int index = int.Parse(command[1]);
                Console.WriteLine(index % 4);
                command = Console.ReadLine().Split();
            }
        }
    }
}
