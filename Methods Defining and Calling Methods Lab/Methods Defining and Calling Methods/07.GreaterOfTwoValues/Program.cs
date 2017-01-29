using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            switch (type)
            {
                case "int":
                    int firstIntValue = int.Parse(Console.ReadLine());
                    int secondIntValue = int.Parse(Console.ReadLine());
                    int maxIntValue = GetMax(firstIntValue, secondIntValue);
                    Console.WriteLine(maxIntValue);
                    break;
                case "char":
                    char firstCharValue = char.Parse(Console.ReadLine());
                    char secondCharValue = char.Parse(Console.ReadLine());
                    char maxCharValue = GetMax(firstCharValue, secondCharValue);
                    Console.WriteLine(maxCharValue);
                    break;
                case "string":
                    string firstStringValue = Console.ReadLine();
                    string secondStringValue = Console.ReadLine();
                    string maxStringValue = GetMax(firstStringValue, secondStringValue);
                    Console.WriteLine(maxStringValue);
                    break;
            }
            
        }
        static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }

            return second;
        }

        static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }

            return second;
        }

        static string GetMax(string first, string second)
        {
            int biggerString = first.CompareTo(second);

            if (biggerString > 0)
            {
                return first;
            }

            return second;
        }
    }
}
