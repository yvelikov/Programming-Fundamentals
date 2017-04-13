namespace _02.CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var inputText = Console.ReadLine().ToLower();

            var substring = Console.ReadLine().ToLower();

            var count = 0;
            var index = -1;

            while (true)
            {
                index = inputText.IndexOf(substring,index+1);
                if (index < 0) break;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
