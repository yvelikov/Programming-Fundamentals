namespace _03.Equal_Sum_After_Extraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
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

            for (int i = 1; i <= firstList.Count; i++)
            {
                for (int j = 1; j <= secondList.Count; j++)
                {
                    if (firstList[i - 1] == secondList[j - 1])
                    {
                        secondList.RemoveAt(j - 1);
                        j--;

                    }
                }
            }

            int sumOfFirstList = GetSum(firstList);
            int sumOfSecondList = GetSum(secondList);

            if (sumOfFirstList == sumOfSecondList)
            {
                Console.WriteLine($"Yes. Sum: {sumOfFirstList}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(sumOfFirstList-sumOfSecondList)}");
            }

        }

        public static int GetSum( List<int>list)
        {

        int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
        return sum;

        }
    }
}
