namespace ConsoleApplication1
{
    using System;
    using System.Linq;
    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[n];
            int maxNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
                if (arrayOfNumbers[i] > maxNumber)
                {
                    maxNumber = arrayOfNumbers[i];
                }
            }

            Console.WriteLine(maxNumber);


        }
    }
}
