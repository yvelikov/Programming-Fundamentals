namespace _01.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {

            var listOfIntegers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int count = 1;
            int bestLength = 1;
            int bestStart = 0;
            int currentLength = 0;

            for (int i = 1; i < listOfIntegers.Count; i++)
            {
                if (listOfIntegers[i] == listOfIntegers[i - 1])
                {
                    count++;
                    if (count > currentLength)
                    {
                        currentLength = count;
                        bestStart = i - count;
                        if (currentLength > bestLength)
                        {
                            bestLength = currentLength;
                            bestStart = i+1 - count;
                        }

                    }

                }
                else
                {
                    count = 1;
                }
               
            }

            for (int i = bestStart; i < (bestStart+bestLength); i++)
            {
                Console.Write($"{listOfIntegers[i]} ");
            }
            Console.WriteLine();
          
        }
    }
}
