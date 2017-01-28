using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            bool digit = 47 < symbol && symbol < 58;
            bool vowel = symbol == 65 || symbol == 69 || symbol == 73 || symbol == 79 || symbol == 85 || symbol == 89 || symbol == 97 || symbol == 101 || symbol == 105 || symbol == 111 || symbol == 117 || symbol == 121;
            if (digit)
            {
                Console.WriteLine("digit");
            }
            else if (vowel)
            {
                Console.WriteLine("vowel");
            }
            else Console.WriteLine("other");

        }
    }
}
