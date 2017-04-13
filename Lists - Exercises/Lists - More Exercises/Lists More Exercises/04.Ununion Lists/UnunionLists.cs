namespace _04.Ununion_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());
            var result = new List<int>();

            while (n > 0)
            {
                var secondaryList = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

                result.Clear();

                for (int i = 0; i < secondaryList.Count; i++)
                {
                    if (!primalList.Contains(secondaryList[i]) && !result.Contains(secondaryList[i]))
                    {
                        result.Add(secondaryList[i]);
                    }
                    
                }

                for (int i = 0; i < primalList.Count; i++)
                {
                    if (!secondaryList.Contains(primalList[i]) && !result.Contains(primalList[i]))
                    {
                        result.Add(primalList[i]);
                    }

                }

                primalList.Clear();

                foreach (var number in result)
                {
                    primalList.Add(number);
                }

                n--;

            }

            result.Sort();
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
