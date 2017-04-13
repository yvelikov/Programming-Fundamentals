namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine()
                .Split('|')
                .ToList();

            var result = new List<string>();

            for (int i = inputNumbers.Count - 1; i >= 0; i--)
            {
                var token = inputNumbers[i].Split(' ');
                foreach (var element in token)
                {
                    if (element != "")
                    {
                        result.Add(element);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
