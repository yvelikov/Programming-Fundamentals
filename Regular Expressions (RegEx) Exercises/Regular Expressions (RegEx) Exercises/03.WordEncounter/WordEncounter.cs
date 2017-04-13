using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.WordEncounter
{
    public class WordEncounter
    {
        public static void Main()
        {
            var filter = Console.ReadLine();

            var filteredChar = filter[0];
            var filteredCharCount = int.Parse(filter[1].ToString());

            var wordRegex = new Regex(@"\w+");

            var validWords = new List<string>();

            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var sentenceRegex = new Regex("[A-Z].+[.?!]");

                var isValid = sentenceRegex.IsMatch(inputLine);
                if (isValid)
                {
                    var sentenceMatches = sentenceRegex.Matches(inputLine);

                    //foreach (Match validSentence in sentenceMatches)
                    //{
                        var words = wordRegex.Matches(inputLine);
                    //  var words = wordRegex.Matches(validSentence);
                        foreach (Match word in words)
                        {
                            var count = 0;
                            foreach (var symbol in word.Value)
                            {
                                if (symbol == filteredChar)
                                {
                                    count++;
                                }
                            }

                            if (count >= filteredCharCount)
                            {
                                validWords.Add(word.Value);
                            }
                        }
                    //}
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", validWords));
        }
    }
}