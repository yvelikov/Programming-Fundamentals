namespace _01.Reverse_String
{
    using System;
    using System.Text;

    public class ReverseString
    {
        public static void Main()
        {
            var text = Console.ReadLine();

            var reversedString = new StringBuilder();

            for (int i = text.Length-1; i >= 0; i--)
            {
                reversedString.Append(text[i]);
            }
            Console.WriteLine(reversedString.ToString());
        }
    }
}
