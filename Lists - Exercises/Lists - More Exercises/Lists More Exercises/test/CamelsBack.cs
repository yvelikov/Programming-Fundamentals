namespace _03.Camel_s_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var buildings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int size = int.Parse(Console.ReadLine());

            int rounds = 0;
            while (buildings.Count > size)
            {
                buildings.RemoveAt(0);
                buildings.RemoveAt(buildings.Count - 1);
                rounds++;
            }
            if (rounds > 0)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: {0}",string.Join(" ",buildings));
            }
            else Console.WriteLine("already stable: {0}", string.Join(" ",buildings));
            



        }
    }
}