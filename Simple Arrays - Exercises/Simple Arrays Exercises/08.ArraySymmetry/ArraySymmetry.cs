namespace _08.ArraySymmetry
{
    using System;
    public class ArraySymmetry
    {
        public static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split(' ');

            int count = 0;
            for (int i = 0; i < arrayOfStrings.Length/2; i++)
            {
                if (arrayOfStrings[i] == arrayOfStrings[arrayOfStrings.Length - 1 - i])
                {
                    count++;
                }
                else break;
            }

            if (count == arrayOfStrings.Length / 2)
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }
    }
}
