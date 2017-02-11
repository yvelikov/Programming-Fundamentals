namespace _07.CountOfCapitalLettersInArray
{
    using System;
    public class CountOfCapitalLettersInArray
    {
        public static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ');

            int count = 0;
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                string currentString = arrayOfStrings[i];
                if (currentString.Length == 1 && currentString[0] > 64 && currentString[0] < 91)
                {
                    count++;
                }
            }

            Console.WriteLine(count);


        }
    }
}
