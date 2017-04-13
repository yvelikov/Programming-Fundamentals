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

            while (grapes.Count > n)
            {
                int growthDays = n;

                while (growthDays > 0)
                {
                    var normalGrapes = new List<int>();
                    var lesserGrapes = new List<int>();
                    var greaterGrapes = new List<int>();

                    for (int i = 0; i < grapes.Count; i++)
                    {

                        if (i == 0)
                        {
                            if (grapes[i] > grapes[i + 1])
                            {
                                grapes[i]++;
                            }
                            else if (grapes[i] < grapes[i + 1] && grapes[i + 1] > grapes[i + 2] && grapes[i] > 0)
                            {
                                grapes[i]--;
                            }
                            else grapes[i]++;
                        }
                        else if (i < grapes.Count - 1)
                        {
                            if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                            {
                                if (grapes[i - 1] > 0 && grapes[i + 1] > 0)
                                {
                                    grapes[i] += 2;
                                    grapes[i - 1]--;
                                    grapes[i + 1]--;
                                }
                                else if (grapes[i - 1] == 0 || grapes[i + 1] == 0)
                                {
                                    grapes[i]++;
                                    if (grapes[i - 1] > 0) grapes[i - 1]--;
                                    if (grapes[i + 1] > 0) grapes[i + 1]--;
                                }

                            }
                            //else if ( ) ;

                        }
                        else
                        {
                            if (grapes[i] > grapes[i - 1])
                            {
                                grapes[i]++;
                            }
                            else if (grapes[i] < grapes[i - 1] && grapes[i - 1] > grapes[i - 2] && grapes[i] > 0)
                            {
                                grapes[i]--;
                            }
                            else grapes[i]++;
                        }

                    }

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
            }

            Console.WriteLine("=============");
            Console.WriteLine(string.Join(" ", grapes));
        }
    }
}
