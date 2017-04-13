namespace _01.ReplaceATag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceATag
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var pattern = @"<a.*href=(.*?)>(.*?)<.a>";
            var replacement = @"[URL href=$1]$2[/URL]";
            var regex = new Regex(pattern);
            

            while (inputLine != "end")
            {
                var result = regex.Replace(inputLine,replacement);
                Console.WriteLine(result);
                inputLine = Console.ReadLine();
            }
        }
    }
}
