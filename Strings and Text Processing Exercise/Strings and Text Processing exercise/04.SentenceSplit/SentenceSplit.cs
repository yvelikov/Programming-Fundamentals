using System;
using System.Collections.Generic;
using System.Text;

namespace _04.SentenceSplit
{
    public class SentenceSplit
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var delimiter = Console.ReadLine();

            var listOfSubstrings = new List<string>();
            var delimiterIndex = -1;

            var index = 0;
            while (true)
            {
                var currentSubstring = new StringBuilder();
                delimiterIndex = inputLine.IndexOf($"{delimiter}", delimiterIndex + 1);
                if (delimiterIndex < 0)
                {
                    for (int i = index; i < inputLine.Length; i++)
                    {
                        currentSubstring.Append(inputLine[i]);
                    }
                    listOfSubstrings.Add(currentSubstring.ToString());
                    break;
                }

                for (int i = index; i < delimiterIndex; i++)
                {
                    currentSubstring.Append(inputLine[i]);
                }
                index = delimiterIndex + delimiter.Length;
                listOfSubstrings.Add(currentSubstring.ToString());
            }

            Console.WriteLine($"[{string.Join(", ", listOfSubstrings)}]");
        }
    }
}
