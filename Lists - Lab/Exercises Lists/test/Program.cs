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
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToList();
            var parsedNumbers = new List<int>();
            

            for (int i = 0; i < numbers.Count; i++)
            {
                foreach (var num in numbers[i])
                {
                   parsedNumbers.Add(num - '0');
                }
            }

            Console.WriteLine(string.Join(" ", parsedNumbers));

         
            //int[] reversed = new int[parsedNumbers.Length];

            //for (int i = 0; i < parsedNumbers.Length; i++)
            //{
            //    reversed[parsedNumbers.Length - i - 1] = parsedNumbers[i];
            //}

            //for (int i = 0; i < reversed.Length; i++)
            //{
            //    Console.WriteLine(reversed[i]);
            //}

        }
    }
}
