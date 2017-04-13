namespace _06.StuckZipper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstListCounter = new List<int>();
            firstListCounter = FillList(firstList);
            
            var secondListCounter = new List<int>();
            secondListCounter = FillList(secondList);
            
            int firstListMin = GetMin(firstListCounter);
            int secondListMin = GetMin(secondListCounter);
            int min = Math.Min(firstListMin, secondListMin);
            
            firstListCounter.Clear();
            secondListCounter.Clear();
            firstListCounter = FillList(firstList);
            secondListCounter = FillList(secondList);

            firstList = RemoveNumbers(firstList, firstListCounter, min);
            secondList = RemoveNumbers(secondList, secondListCounter, min);

            int firstListCountAfterRemoval = firstList.Count;
            int secondListCountAfterRemoval = secondList.Count;
            int difference = Math.Abs(firstListCountAfterRemoval - secondListCountAfterRemoval);

            if (firstList.Count == 0)
            {
                Console.WriteLine(string.Join(" ", secondList));
            }
            else if (secondList.Count == 0)
            {
                Console.WriteLine(string.Join(" ", firstList));
            }
            else
            {
                if (firstListCountAfterRemoval < secondListCountAfterRemoval)
                {
                    for (int i = 0; i < secondList.Count-difference; i++)
                    {
                        secondList.Insert(i + 1, firstList[i / 2]);
                        i++;
                    }
                }

                else if (firstListCountAfterRemoval >= secondListCountAfterRemoval)
                {
                    for (int i = 0; i < secondList.Count; i++)
                    {
                        secondList.Insert(i + 1, firstList[i / 2]);
                        i++;
                    }
                    for (int i = firstListCountAfterRemoval - difference; i < firstListCountAfterRemoval; i++)
                    {
                        secondList.Add(firstList[i]);
                    }
                }
            
                Console.WriteLine(string.Join(" ", secondList));
            }
        }

        public static List<int> RemoveNumbers(List<int> firstList, List<int> firstListCounter, int min)
        {
            int amountOfDigits = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                while (Math.Abs(firstListCounter[i]) > 0)
                {
                    firstListCounter[i] /= 10;
                    amountOfDigits++;
                }

                if (amountOfDigits > min)
                {
                    firstList.RemoveAt(i);
                    amountOfDigits = 0;
                    firstListCounter = FillList(firstList);
                    i--;
                }
                else 
                amountOfDigits = 0;
            }

            return firstList;
        }

        public static int GetMin(List<int> firstListCounter )
        {
            int min = int.MaxValue;
            int amountOfDigits = 0;

            for (int i = 0; i < firstListCounter.Count; i++)
            {
                while (Math.Abs(firstListCounter[i]) > 0)
                {
                    firstListCounter[i] /= 10;
                    amountOfDigits++;
                }

                if (amountOfDigits < min)
                {
                    min = amountOfDigits;

                }
                amountOfDigits = 0;
            }
            return min;
        }

        public static List<int> FillList(List<int> firstList)
        {
            var firstListCounter = new List<int>();

            foreach (var number in firstList)
            {
                firstListCounter.Add(number);
            }
            return firstListCounter;
        }
    }
}
