namespace _03.UnicodeCharacters
{
    using System;

    public class UnicodeCharacters
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            foreach (var symbol in inputLine)
            {
                Console.Write("\\u{0:x4}", (int)symbol);
            }
        }
    }
}
