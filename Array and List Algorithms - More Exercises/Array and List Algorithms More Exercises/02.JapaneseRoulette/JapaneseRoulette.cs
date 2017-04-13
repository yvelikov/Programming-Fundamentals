namespace _02.JapaneseRoulette
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var bullets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var players = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int dead = 0; 

            for (int i = 0; i < players.Length; i++)
            {
                string[] currentPlayer = players[i].Split(',');
                int playerStrength = int.Parse(currentPlayer[0]);
                string direction = currentPlayer[1];
                if (direction == "Right")
                {
                    bullets = SpinRight(playerStrength, bullets);
                }
                else if (direction == "Left")
                {
                    bullets = SpinLeft(playerStrength, bullets);
                }
                
                if (bullets[2] == 1)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    dead = 1;
                    break;
                }
                bullets = SpinRight(1, bullets);

            }

            if (dead == 0)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        private static int[] SpinLeft(int playerStrength, int[] bullets)
        {
            var count = 0;
            var result = new int[bullets.Length];
            while (count < playerStrength)
            {
                var firstElement = bullets[0];

                for (int i = 0; i < bullets.Length-1; i++)
                {
                    result[i] = bullets[i + 1];
                }
                result[result.Length - 1] = firstElement;

                for (int i = 0; i < result.Length; i++)
                {
                    bullets[i] = result[i];
                }
                count++;
                
            }
            return bullets;
        }

        public static int[] SpinRight(int playerStrength, int[] bullets)
        {
            var count = 0;
            var result = new int[bullets.Length];
            while (count < playerStrength)
            {
                 var lastElement = bullets[bullets.Length - 1];

                for (int i = 0; i < bullets.Length - 1; i++)
                {
                    result[i + 1] = bullets[i];
                }
                result[0] = lastElement;

                for (int i = 0; i < result.Length; i++)
                {
                    bullets[i] = result[i];
                }
                count++;
            }
            return bullets;
        }
    }
}
