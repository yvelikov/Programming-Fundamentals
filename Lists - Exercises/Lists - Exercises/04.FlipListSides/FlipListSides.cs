namespace _04.FlipListSides
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FlipListSides
    {
        public static void Main()
        {
            var integerList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int length = integerList.Count;
            
                for (int i = 1; i < length / 2; i++)
                {
                    int currentElement = integerList[i];
                    integerList[i] = integerList[length - 1 - i];
                    integerList[length - 1 - i] = currentElement;
                }

            Console.WriteLine(string.Join(" ",integerList));
        }
    }
}
