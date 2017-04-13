namespace _04.Palindromes
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new[] { ' ','?','!','.',','},StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new HashSet<string>();

            foreach (var word in text)
            {
                var reversedWord = new StringBuilder();
                for (int i = 0; i < word.Length; i++)
                {
                    reversedWord.Append(word[word.Length - 1 - i]);
                }
                if (word == reversedWord.ToString())
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",palindromes.OrderBy(x=>x)));
        }
    }
}
