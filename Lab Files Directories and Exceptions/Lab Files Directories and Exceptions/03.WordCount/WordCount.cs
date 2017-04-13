namespace _03.WordCount
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").Split(' ');

            var text = File.ReadAllText("text.txt").ToLower().Split(new[] { '-',' ', ',', '.','!','?', },StringSplitOptions.RemoveEmptyEntries);

            var result = new Dictionary<string,int>();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (words[i] == text[j])
                    {
                        if (!result.ContainsKey(words[i]))
                        {
                            result[words[i]] = 0;
                        }
                        result[words[i]]++;
                    }
                }
            }

            var output = result.OrderByDescending(x => x.Value);

            foreach (var kvp in output)
            {
                File.AppendAllText("output.txt", kvp.Key +" - " + kvp.Value + Environment.NewLine);
            }
        }
    }
}
