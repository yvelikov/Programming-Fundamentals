
namespace _04.WinningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] {',' }, StringSplitOptions.RemoveEmptyEntries);

            var tickets = new List<string>();
            foreach (var input in inputLine)
            {
                tickets.Add(input.Trim());
            }
            //var pattern = @"(\@{6,10}|\${6,10}|\#{6,10}|\^{6,10})";
            var pattern = @"(\@{6,}|\${6,}|\#{6,}|\^{6,})";

            var regex = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    var firstHalf = string.Empty;
                    var secondHalf = string.Empty;

                    for (int i = 0; i < ticket.Length / 2; i++)
                    {
                        firstHalf += ticket[i];
                        secondHalf += ticket[i + ticket.Length / 2];
                    }

                    var firstIsMatch = regex.IsMatch(firstHalf);
                    var secondIsMatch = regex.IsMatch(secondHalf);

                    var firstHalfMatch = regex.Match(firstHalf);
                    var secondHalfMatch = regex.Match(secondHalf);

                    if (firstIsMatch && secondIsMatch)
                    {
                        if (firstHalfMatch.Value[0] == secondHalfMatch.Value[0])
                        {
                            if (firstHalfMatch.Length <= secondHalfMatch.Length && secondHalfMatch.Length != 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {firstHalfMatch.Length}{firstHalfMatch.Value[0]}");
                            }
                            else if (firstHalfMatch.Length > secondHalfMatch.Length && firstHalfMatch.Length != 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {secondHalfMatch.Length}{firstHalfMatch.Value[0]}");
                            }
                            else if (firstHalfMatch.Length == 10 && secondHalfMatch.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - 10{firstHalfMatch.Value[0]} Jackpot!");
                            }
                        }
                        else Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    else
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
                else Console.WriteLine("invalid ticket");
            }
        }
    }
}
