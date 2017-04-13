using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CapitalizeWords
{
    public class CapitalizeWords
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '!', '.', ',', '?', '\\', '/', '"', '|', '[', ']', ' ', ';', ':', '<', '>', '{', '}', '(', ')', '-' }, StringSplitOptions.RemoveEmptyEntries);
                var listOfWords = new List<string>();
                foreach (var word in inputParams)
                {
                    listOfWords.Add(word.ToLower());
                }

                var wordsToPrint = new List<string>();

                for (int i = 0; i < listOfWords.Count; i++)
                {
                    var currentWord = new StringBuilder();
                    for (int j = 0; j < listOfWords[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            currentWord.Append((char)(listOfWords[i][j] - 32));
                        }
                        else currentWord.Append(listOfWords[i][j]);
                    }
                    wordsToPrint.Add(currentWord.ToString());
                }
                Console.WriteLine($"{string.Join(", ", wordsToPrint)}");
                inputLine = Console.ReadLine();
            }

        }
    }
}
