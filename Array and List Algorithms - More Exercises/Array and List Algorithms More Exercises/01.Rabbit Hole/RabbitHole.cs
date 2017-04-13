namespace _01.Rabbit_Hole
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class RabbitHole
    {
        public static void Main()
        {
            var obstacles = Console.ReadLine()
                .Split(' ')
                .ToList();

            var energy = int.Parse(Console.ReadLine());

            for (int i = 0; i < obstacles.Count; i++)
            {
                string[] currentObstacle = obstacles[i].Split('|');
                if (currentObstacle[0] == "Right")
                {
                    energy -= int.Parse(currentObstacle[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }

                    i = TakeRightJump(obstacles, i, currentObstacle);
                    i--;
                    obstacles = RemoveLastElement(obstacles);
                    obstacles.Add($"Bomb|{energy}");
                    
                }
                else if (currentObstacle[0] == "Left")
                {
                    energy -= int.Parse(currentObstacle[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are tired. You can't continue the mission.");
                        break;
                    }

                    i = TakeLeftJump(obstacles, i, currentObstacle);
                    i--;
                    obstacles = RemoveLastElement(obstacles);
                    obstacles.Add($"Bomb|{energy}");
                    
                }
                else if (currentObstacle[0] == "Bomb")
                {
                    obstacles.RemoveAt(i);
                    energy -= int.Parse(currentObstacle[1]);
                    if (energy <= 0)
                    {
                        Console.WriteLine("You are dead due to bomb explosion!");
                        break;
                    }
                    obstacles = RemoveLastElement(obstacles);
                    obstacles.Add($"Bomb|{energy}");
                    i = 0;
                    i--;

                }
                else if (currentObstacle[0] == "RabbitHole")
                {
                    Console.WriteLine("You have 5 years to save Kennedy!");
                    break;
                }
            }
        }

        public static int TakeLeftJump(List<string> obstacles, int i, string[] currentObstacle)
        {
            var jump = int.Parse(currentObstacle[1]);
            i = Math.Abs(i - jump) % obstacles.Count;
            return i;
        }

        public static int TakeRightJump(List<string> obstacles, int i, string[] currentObstacle)
        {
            var jump = int.Parse(currentObstacle[1]);
            if (i + jump > obstacles.Count)
            {
                var count = 0;
                while (count != jump)
                {
                    if (i == obstacles.Count)
                    {
                        i = 0;
                    }
                    i++;
                    count++;
                }
            }
            else i += jump;
            return i;
        }

        public static List<string> RemoveLastElement(List<string> obstacles)
        {
            if (obstacles[obstacles.Count - 1] != "RabbitHole")
            {
                obstacles.RemoveAt(obstacles.Count - 1);
            }
            return obstacles;
        }
    }
}
