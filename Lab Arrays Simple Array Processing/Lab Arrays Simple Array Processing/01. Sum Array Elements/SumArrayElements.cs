

namespace _01.Sum_Array_Elements
{
    using System;

    public class SumArrayElements
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
