namespace _01.RemoveElementsАtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RemoveElementsАtOddPositions
    {
        public static void Main()
        {
            var inputString = Console.ReadLine()
                .Split(' ')
                .ToList();

            var result = new List<string>();
            for (int i = 0; i < inputString.Count; i++)
            {
                if (i % 2 != 0)
                {
                    result.Add(inputString[i]);
                }
            }
            Console.WriteLine(string.Join("",result));
        }
    }
}
