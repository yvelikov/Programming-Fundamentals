using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            ulong biggerNumber = Math.Max(num1,num2);
            ulong smallerNumber = Math. Min(num1, num2);
            var biggerNumberType = "";
            var smallerNumberType = "";
            ulong overflow = 1;

            if (biggerNumber == num1)
            {
                if (byte.MinValue <= num1 && num1 <= byte.MaxValue)
                {
                    biggerNumberType = "byte";
                }
                else if (ushort.MinValue <= num1 && num1 <= ushort.MaxValue)
                {
                    biggerNumberType = "ushort";
                }
                else if (uint.MinValue <= num1 && num1 <= uint.MaxValue)
                {
                    biggerNumberType = "unit";
                }
                else biggerNumberType = "ulong";

                if (byte.MinValue <= num2 && num2 <= byte.MaxValue)
                {
                    smallerNumberType = "byte";
                }
                else if (ushort.MinValue <= num2 && num2 <= ushort.MaxValue)
                {
                    smallerNumberType = "ushort";
                }
                else if (uint.MinValue <= num2 && num2 <= uint.MaxValue)
                {
                    smallerNumberType = "unit";
                }
                else smallerNumberType = "ulong";


                switch (biggerNumberType)
                    {
                    case "byte": overflow = num1/byte.MaxValue;
                    break;
                    case "ushort":
                        overflow = num1 / byte.MaxValue;
                        break;
                    case "byte":
                        overflow = num1 / byte.MaxValue;
                        break;
                    case "byte":
                        overflow = num1 / byte.MaxValue;
                        break;
                }
            }
            
            
        }
    }
}
