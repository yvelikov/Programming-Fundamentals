namespace _06.Winecraft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Winecraft
    {
        public static void Main()
        {
            var grapes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            var normalGrapes = new List<int>();
            var lesserGrapes = new List<int>();
            var greaterGrapes = new List<int>();

           // while (/*grapes.Count > n*/)
            //{
                int growthDays = n;

                while (growthDays > 0)
                {
                    for (int i = 0; i < grapes.Count; i++)
                    {
                    


                    }
                    Console.WriteLine("key normal: {0}", string.Join(" ",normalGrapes));
                    Console.WriteLine("key lesser: {0}", string.Join(" ", lesserGrapes));
                    Console.WriteLine("key greater: {0}", string.Join(" ", greaterGrapes));

                    growthDays--;
                    Console.WriteLine("Round {0}: {1}", n - growthDays, string.Join(" ", grapes));
                }

                for (int i = 0; i < grapes.Count; i++)
                {
                    if (grapes[i] < n)
                    {
                        grapes.RemoveAt(i);
                        i--;
                    }
                }
            //}

            Console.WriteLine("=============");
            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}

