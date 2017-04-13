namespace _02.RotateАndSum
{
    using System;
    using System.Linq;

    public class RotateАndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[array.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                int lastElement = array[array.Length - 1];

                for (int j = array.Length-1; j >0; j--)
                {
                    array[j] = array[j-1]; 
                }
                
                array[0] = lastElement;

                for (int k = 0; k < array.Length; k++)
                {
                    sum[k] += array[k];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
