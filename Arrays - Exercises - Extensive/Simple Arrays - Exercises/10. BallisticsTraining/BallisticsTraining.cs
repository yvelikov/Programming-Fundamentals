using System;
using System.Linq;
namespace _10.BallisticsTraining
{
    public class BallisticsTraining
    {
        public static void Main()
        {
            long[] coordinates = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            string[] commandSequence = Console.ReadLine().Split(' ');

            long x = 0;
            long y = 0;


            for (int i = 0; i < commandSequence.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (commandSequence[i] == "right")
                    {
                        x += long.Parse(commandSequence[i + 1]);
                    }
                    if (commandSequence[i] == "left")
                    {
                        x -= long.Parse(commandSequence[i + 1]);
                    }
                    if (commandSequence[i] == "up")
                    {
                        y += long.Parse(commandSequence[i + 1]);
                    }
                    if (commandSequence[i] == "down")
                    {
                        y -= long.Parse(commandSequence[i + 1]);
                    }
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");
            if (x == coordinates[0] && y == coordinates[1])
            {
                Console.WriteLine("got 'em!");
            }
            else
                Console.WriteLine("better luck next time...");

        }
    }
}
