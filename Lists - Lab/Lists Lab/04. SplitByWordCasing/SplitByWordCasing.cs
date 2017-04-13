namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var inputText = Console.ReadLine()
                .Split(' ', ',', ';',':','.','(',')','\"','\'','\\','/','[',']','!')
                .ToList();

            var spliText = new List<string>();

            foreach (var word in inputText)
            {
                if (word != "")
                {
                    spliText.Add(word);
                }
            }

            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();

            foreach (var word in spliText)
            {
                int upperCase = 0;
                int lowerCase = 0;
                foreach (var character in word)
                {
                    if (character >= 65 && character <= 90)
                    {
                        upperCase++;
                    }
                    else if (character >= 97 && character <= 122)
                    {
                        lowerCase++;
                    }

                }

                if (upperCase == word.Length)
                {
                    upperCaseWords.Add(word);
                }
                else if (lowerCase == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
                else mixedCaseWords.Add(word);
            }

            Console.WriteLine("Lower-case: {0}",string.Join(", ",lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
