namespace _03.FoldАndSum
{
    using System;

    public class FoldАndSum
    {
        public static void Main()
        {
            string[] inputNumbers = Console.ReadLine().Split();
            int length = inputNumbers.Length;
            int k = length / 4;

            int[] parsedNumbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
            }

            int[] firstRow = new int[length / 2];
            int[] secondRow = new int[length / 2];
            int[] leftPart = new int[length/4];
            int[] rightPart = new int[length / 4]; 

            for (int i = 0; i < k ; i++)
            {
                leftPart[i] = parsedNumbers[i];
            }
            
            int[] reversedLeftPart = new int[leftPart.Length];

            ReverseArray(reversedLeftPart,leftPart);
            ReverseArray(rightPart, parsedNumbers);    
            
            for (int i = 0; i < firstRow.Length; i++)
            {
                if (i < k)
                    firstRow[i] = reversedLeftPart[i];
                else
                    firstRow[i] = rightPart[i - k];
            }

            for (int i = 0; i < secondRow.Length; i++)
            {
                secondRow[i] = parsedNumbers[i + k];
            }

            int[] sum = new int[length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i]; 
            }

           Console.WriteLine(string.Join(" ", sum));
            
        }

        static void ReverseArray(int[] firstArray, int[] secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = secondArray[secondArray.Length - 1 - i];
            }
        }
    }
}
