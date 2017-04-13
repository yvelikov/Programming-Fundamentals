namespace _03.SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayOfStrings
    {
        public static void Main()
        {

            string[] inputString = Console.ReadLine().Split(' ');

            bool swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < inputString.Length - 1; i++)
                {
                    int returnValue = inputString[i].CompareTo(inputString[i + 1]);
                    if (returnValue > 0)
                    {
                        string currentString = inputString[i];
                        inputString[i] = inputString[i + 1];
                        inputString[i + 1] = currentString;
                        swapped = true;

                    }
                }
            }
            while (swapped);



            Console.WriteLine(string.Join(" ", inputString));

        }
    }
}
