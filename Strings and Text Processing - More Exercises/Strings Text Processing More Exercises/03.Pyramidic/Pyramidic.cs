namespace _03.Pyramidic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pyramidic
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var listOfStrings = new List<string>();
            var pyramids = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                listOfStrings.Add(line);
            }

            for (int i = 0; i < listOfStrings.Count; i++)
            {
                var currentLine = listOfStrings[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    var level = 1;
                    var currentPyramid = string.Empty;
                    for (int k = i; k < listOfStrings.Count; k++)
                    {
                        string pyramidLayer = new string(currentLine[j], level);

                        if (listOfStrings[k].Contains(pyramidLayer))
                        {
                            currentPyramid += pyramidLayer + "\r\n";
                        }
                        else break;
                        level += 2;
                    }
                    pyramids.Add(currentPyramid.Trim());
                }
            }

            Console.WriteLine(pyramids.OrderByDescending(x=>x.Length).First());
        }
    }
}
