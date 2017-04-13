namespace _02.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();

            var result = new List<string>();

            input.Reverse();
            foreach (var item in input)
            {
                var numbers = item.Split(' ').ToList();
                foreach (var number in numbers)
                {
                    if (number != "")
                    {
                        result.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",result));

        }
    }
}
