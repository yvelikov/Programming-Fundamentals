namespace _02.ExtractSentencesByKeyword
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var keyword = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new[] { '?','.','!'});

            var pattern = "\\b" + keyword + "\\b";
            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                var match = regex.IsMatch(sentence);
                if (match)
                Console.WriteLine(sentence.Trim());
            }
        }
    }
}
