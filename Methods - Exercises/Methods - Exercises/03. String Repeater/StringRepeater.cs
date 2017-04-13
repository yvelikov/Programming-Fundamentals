using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.String_Repeater
{
    class StringRepeater
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string repeatedString = RepeatString(text, count);
            Console.WriteLine(repeatedString);
        }
        static string RepeatString(string text, int count)
        {
            string repeatedString =string.Empty;
            for (int i = 1; i <= count; i++)
            {
                
                repeatedString += text;
            }
            return repeatedString;
        }
    }
}
