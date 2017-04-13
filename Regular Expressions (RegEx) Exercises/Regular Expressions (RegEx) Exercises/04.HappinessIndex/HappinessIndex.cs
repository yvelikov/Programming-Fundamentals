namespace _04.HappinessIndex
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class HappinessIndex
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var happyPattern = @"(:\)|:D|;\)|:\*|:\]|;\]|:\}|;\}|\(:|\*:|c:|\[:|\[;)";
            var sadPattern = @"(:\(|D:|;\(|:\[|;\[|:\{|;\{|\):|:c|\]:|\];)";

            var happyRegex = new Regex(happyPattern);
            var sadRegex = new Regex(sadPattern);

            var emoticons = new List<Match>();

            var happyMatches = happyRegex.Matches(inputLine);
            var sadMatches = sadRegex.Matches(inputLine);

            var happyCount = 0;
            foreach (Match match in happyMatches)
            {
                happyCount++;
            }
            var sadCount = 0;
            foreach (Match match in sadMatches)
            {
                sadCount++;
            }

            double happinessIndex = Math.Round((double)( happyCount / (double)sadCount),2);

            var emoticon = string.Empty;

            if (happinessIndex >= 2)
            {
                emoticon = ":D";
            }
            else if (happinessIndex > 1)
            {
                emoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                emoticon = ":|";
            }
            else emoticon = ":(";

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {emoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");

        }
    }
}
