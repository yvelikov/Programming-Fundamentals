namespace _05.TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var topHalf = new List<int>();
            var bottomHalf = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count / 2)
                {
                    bottomHalf.Add(numbers[i]);
                }
                else
                {
                    topHalf.Add(numbers[i]);
                }

            }

            for (int i = 0; i < bottomHalf.Count; i++)
            {
                for (int j = 0; j < topHalf.Count; j++)
                {
                    int leftNumber = topHalf[j] / 10;
                    int rightNumber = topHalf[j] % 10;

                    bottomHalf.Insert(i, leftNumber);
                    bottomHalf.Insert(i + 2, rightNumber);
                    i = i + 3;
                }
                

            }

            Console.WriteLine(string.Join(" ", bottomHalf));
        }
    }
}
