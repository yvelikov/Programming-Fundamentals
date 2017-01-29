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
            double overflow = 1;

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
                    biggerNumberType = "uint";
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
                    smallerNumberType = "uint";
                }
                else smallerNumberType = "ulong";


                switch (smallerNumberType)
                {
                    case "byte":
                        overflow = Math.Round((double)((double)num1 / (double)byte.MaxValue));
                        break;
                    case "ushort":
                        overflow = Math.Round((double)((double)num1 / (double)ushort.MaxValue));
                        break;
                    case "uint":
                        overflow = Math.Round((double)((double)num1 / (double)uint.MaxValue));
                        break;
                    case "ulong":
                        overflow = Math.Round((double)((double)num1 / (double)ulong.MaxValue));
                        break;
                }
                
                
            }
            else if (biggerNumber == num2)
            {
                if (byte.MinValue <= num2 && num2 <= byte.MaxValue)
                {
                    biggerNumberType = "byte";
                }
                else if (ushort.MinValue <= num2 && num2 <= ushort.MaxValue)
                {
                    biggerNumberType = "ushort";
                }
                else if (uint.MinValue <= num2 && num2 <= uint.MaxValue)
                {
                    biggerNumberType = "uint";
                }
                else biggerNumberType = "ulong";

                if (byte.MinValue <= num1 && num1 <= byte.MaxValue)
                {
                    smallerNumberType = "byte";
                }
                else if (ushort.MinValue <= num1 && num1 <= ushort.MaxValue)
                {
                    smallerNumberType = "ushort";
                }
                else if (uint.MinValue <= num1 && num1 <= uint.MaxValue)
                {
                    smallerNumberType = "uint";
                }
                else smallerNumberType = "ulong";


                switch (smallerNumberType)
                {
                    case "byte":
                        overflow = Math.Round((double)((double)num2 / (double)byte.MaxValue));
                        break;
                    case "ushort":
                        overflow = Math.Round((double)((double)num2 / (double)ushort.MaxValue));
                        break;
                    case "uint":
                        overflow = Math.Round((double)((double)num2 / (double)uint.MaxValue));
                        break;
                    case "ulong":
                        overflow = Math.Round((double)((double)num2 / (double)ulong.MaxValue));
                        break;
                }
            }
            
            Console.WriteLine($"bigger type: {biggerNumberType}");
            Console.WriteLine($"smaller type: {smallerNumberType}");
            Console.WriteLine($"{biggerNumber} can overflow {smallerNumberType} {overflow} times");
            
            
        }
    }
}
