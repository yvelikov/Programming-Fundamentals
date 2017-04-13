namespace _01.ShootListElements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShootListElements
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var listOfElements = new List<int>();
            var average = 0d;
            var firsIntSmallerThanAverage = 0;
            bool nobodyLeft = false;

            while (command != "stop")
            {
                if (command != "bang")
                {
                    listOfElements.Insert(0, int.Parse(command));
                }
                else if (command == "bang")
                {
                    if (listOfElements.Count != 0)
                    {
                        average = GetAverage(listOfElements);
                        firsIntSmallerThanAverage = GetSmallestInt(listOfElements, average);
                        listOfElements.Remove(firsIntSmallerThanAverage);
                        Console.WriteLine($"shot {firsIntSmallerThanAverage}");
                        listOfElements = Decrement(listOfElements);
                    }
                    else
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {firsIntSmallerThanAverage}");
                        nobodyLeft = true;
                        command = "stop";
                    }
                    
                }

                if (command != "stop") 
                command = Console.ReadLine();
            }

            if (listOfElements.Count > 0 )
            {
                Console.WriteLine("survivors: {0}", string.Join(" ",listOfElements));
            }
            else if (listOfElements.Count == 0 && !nobodyLeft)
                Console.WriteLine($"you shot them all. last one was {firsIntSmallerThanAverage}");
        }

        public static List<int> Decrement(List<int> listOfElements)
        {
            for (int i = 0; i < listOfElements.Count; i++)
            {
                listOfElements[i]--;
            }

            return listOfElements;
        }

        public static int GetSmallestInt(List<int> listOfElements, double average)
        {
            var firstIntSmallerThanAverage = 0;
            for (int i = 0; i < listOfElements.Count; i++)
            {
                if (listOfElements[i] <= average)
                {
                    firstIntSmallerThanAverage = listOfElements[i];
                    break;
                }
            }
            return firstIntSmallerThanAverage;
        }

        public static double GetAverage(List<int> listOfElements)
        {
            var average = 0d;
            var sum = 0d;

            for (int i = 0; i < listOfElements.Count; i++)
            {
                sum += listOfElements[i];
            }

            average = (sum / listOfElements.Count);
            return average;

        }
    }
}
