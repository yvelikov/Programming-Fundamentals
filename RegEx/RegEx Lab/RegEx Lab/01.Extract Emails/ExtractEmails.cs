namespace _01.Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;
    public class ExtractEmails
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

            var regex = new Regex(pattern);

            var matches = regex.Matches(inputLine);

            foreach (var match in matches)
            {
                var currentMatch = match.ToString();

                if (!(currentMatch.StartsWith(".")||
                    currentMatch.StartsWith("-")||
                    currentMatch.StartsWith("_")||
                    currentMatch.EndsWith(".")||
                    currentMatch.EndsWith("-")||
                    currentMatch.EndsWith("_")))
                {
                    Console.WriteLine(currentMatch);
                }
            }
        }
    }
}
