namespace _03.IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var sequence = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();
                if (result.Count == 0)
                {
                    bool isIncreasing = CheckSequence(sequence);
                    if (!isIncreasing)
                    {
                        sequence = RemoveDecreasingElements(sequence);
                    }
                    result = FillList(sequence);
                }
                else
                {
                    var rightMostLowerElement = FindRightMostLowerElement(sequence[0],result);
                    bool isIncreasing = CheckSequence(sequence);
                    if (isIncreasing)
                    {
                        result = AddSequence(result, sequence, rightMostLowerElement);
                       
                    }
                    else
                    {
                        result = AddSequence(result, sequence, rightMostLowerElement);
                        
                        //for (int j = result.Count - 1; j > rightMostLowerElement; j--)
                        //{
                        //    result.RemoveAt(j);
                        //}
                        result = RemoveDecreasingElements(result);
                        
                    }
                } 
            }

            Console.WriteLine(string.Join(" ",result));
        }

        public static List<int> RemoveDecreasingElements(List<int> sequence)
        {
            var decreasingElement = 0;
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    decreasingElement = i+1;
                    break;
                }
            }

            for (int i = sequence.Count - 1; i >= decreasingElement; i--)
            {
                sequence.RemoveAt(i);
            }
            
            return sequence;
        }

        public static List<int> AddSequence(List<int> result, List<int> sequence, int rightMostLowerElement)
        {
            bool isIncreasing = true;
            int lastAddedElement = 0;
            
            for (int i = 0; i < sequence.Count; i++)
            {
                if (rightMostLowerElement + i + 1 > rightMostLowerElement + i)
                {
                    result.Insert(rightMostLowerElement + i + 1, sequence[i]);
                    lastAddedElement = i+1;
                    isIncreasing = CheckSequence(result);
                    if (!isIncreasing)
                    {
                        break;
                    }
                }
            }

            
            return result;
        }

        public static bool CheckSequence(List<int> sequence)
        {
            var count = 0;
            for (int i = 0; i < sequence.Count-1; i++)
            {
                if (sequence[i] > sequence[i + 1])
                {
                    count++;
                }
            }
            if (count == 0)
            {
                return true;
            }
            else return false;
            
        }

        public static int FindRightMostLowerElement(int v, List<int> result)
        {
            var rightMostLowerElement = 0;
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] <= v)
                {
                    rightMostLowerElement = i;
                }
            }
            return rightMostLowerElement;
        }

        public static List<int> FillList(List<int> sequence)
        {
            var result = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                result.Add(sequence[i]);
            }
            return result;
        }
    }
}
