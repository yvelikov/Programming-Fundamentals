namespace _02.AverageCharDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] inputString = Console.ReadLine().Split(' ');

            int sum = 0;
            int count = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                foreach (var character in inputString[i])
                {
                    sum += character;
                    count++;
                }

            }
            int average = sum / count;

            if (average >= 97 && average <= 122)
            {
                average -= 32;
            }
            
            Console.WriteLine(string.Join($"{(char)average}",inputString));
                
        }
    }
}
