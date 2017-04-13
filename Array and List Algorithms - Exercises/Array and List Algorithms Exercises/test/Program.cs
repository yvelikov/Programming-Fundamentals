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
            string freq = "83.105";

            string[] arr = freq.Split('.');

            var result = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                result.Add(int.Parse(arr[i]));
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
