


namespace _01.LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArrayOfWords = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string[] secondArrayOfWords = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int leftEndCount = 0;
            int rightEndCount = 0;

            int shorter = Math.Min(firstArrayOfWords.Length,secondArrayOfWords.Length);
           

            for (int i = 0; i < shorter; i++)
            {
                if (firstArrayOfWords[i] == secondArrayOfWords[i])
                {
                    leftEndCount++;
                }
                else break;
            }

            int difference = Math.Abs(firstArrayOfWords.Length - secondArrayOfWords.Length);

            if (firstArrayOfWords.Length >= secondArrayOfWords.Length)
            {
                for (int i = firstArrayOfWords.Length - 1; i >= difference; i--)
                {
                    if (firstArrayOfWords[i] == secondArrayOfWords[i - difference])
                    {
                        rightEndCount++;
                    }
                    else break;
                }

            }
            else
            {
                for (int i = secondArrayOfWords.Length - 1; i >= difference; i--)
                {
                    if (firstArrayOfWords[i-difference] == secondArrayOfWords[i])
                    {
                        rightEndCount++;
                    }
                    else break;
                }
            }



            Console.WriteLine(Math.Max(rightEndCount,leftEndCount));


        }
    }
}
