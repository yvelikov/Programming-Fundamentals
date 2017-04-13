namespace _02.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var field = new int[fieldSize];

            var initialIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < initialIndexes.Length; j++)
            {
                var currentIndex = initialIndexes[j];
                if (currentIndex < field.Length && currentIndex >=0 )
                {
                    field[currentIndex] = 1;
                }
            }

            var command = Console.ReadLine();

            while (command != "end")
            {
                var inputParams = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var ladybugIndex = int.Parse(inputParams[0]);
                var direction = inputParams[1];
                var flyLength = int.Parse(inputParams[2]);

                var landIndex = 0;

                if (direction == "right")
                {
                    bool hasNotLanded = true;
                    while (hasNotLanded)
                    {
                        if (ladybugIndex < field.Length && ladybugIndex >= 0)
                        {
                            if (field[ladybugIndex] == 0)
                            {
                                hasNotLanded = false;
                                break;
                            }
                            field[ladybugIndex] = 0;
                            if (Math.Abs(flyLength) < field.Length)
                            {
                                landIndex = ladybugIndex + flyLength;
                            }
                            else break;

                            if (landIndex < field.Length && landIndex >= 0)
                            {
                                while (true)
                                {
                                    if (field[landIndex] == 0)
                                    {
                                        field[landIndex] = 1;
                                        hasNotLanded = false;
                                        break;
                                    }
                                    else if (field[landIndex] == 1)
                                    {
                                        landIndex += flyLength;
                                        if (landIndex >= field.Length)
                                        {
                                            hasNotLanded = false;
                                            break;
                                        }
                                    }
                                }
                            }
                            else hasNotLanded = false;
                        }
                        else hasNotLanded = false;
                    }
                    
                }
                else if (direction == "left")
                {
                    bool hasNotLanded = true;
                    while (hasNotLanded)
                    {
                        if (ladybugIndex < field.Length && ladybugIndex >= 0)
                        {
                            if (field[ladybugIndex] == 0)
                            {
                                hasNotLanded = false;
                                break;
                            }
                            field[ladybugIndex] = 0;
                            if (Math.Abs(flyLength) < field.Length)
                            {
                                landIndex = ladybugIndex - flyLength;
                            }
                            else break;

                            if (landIndex < field.Length && landIndex >= 0)
                            {
                                while (true)
                                {
                                    if (field[landIndex] == 0)
                                    {
                                        field[landIndex] = 1;
                                        hasNotLanded = false;
                                        break;
                                    }
                                    else if (field[landIndex] == 1)
                                    {
                                        landIndex -= flyLength;
                                        if (landIndex >= field.Length)
                                        {
                                            hasNotLanded = false;
                                            break;
                                        }
                                    }
                                }
                            }
                            else hasNotLanded = false;
                        }
                        else hasNotLanded = false;
                    }   
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
