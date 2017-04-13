namespace _04.RotateArrayOfStrings
{
    using System;
    using System.Linq;
    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string[] reversedString = new string[words.Length]; 

            for (int i = 0; i < words.Length-1; i++)
            {
                reversedString[i + 1] = words[i];
            }

            string lastElement = words[reversedString.Length - 1];
            reversedString[0] = lastElement;
            Console.WriteLine(string.Join(" ", reversedString));


        }
    }
}
