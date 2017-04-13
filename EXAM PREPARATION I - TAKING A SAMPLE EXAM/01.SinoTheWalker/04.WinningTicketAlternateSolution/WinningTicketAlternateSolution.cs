namespace _04.WinningTicketAlternateSolution
{
    using System;
    using System.Text.RegularExpressions;

    class WinningTicketAlternateSolution
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var winningPattern = @"(\@{6,10}|\${6,10}|\#{6,10}|\^{6,10})";
            var jackpotPattern = @"(\@{20}|\${20}|\#{20}|\^{20})";

            var winningRegex = new Regex(winningPattern);
            var jackpotRegex = new Regex(jackpotPattern);

            for (int i = 0; i < tickets.Length; i++)
            {
                var currentTicket = tickets[i];

                if (currentTicket.Length == 20)
                {
                    var firstHalf = currentTicket.Substring(0, 10);
                    var secondHalf = currentTicket.Substring(10, 10);
                    var firstHalfIsMatch = winningRegex.IsMatch(firstHalf);
                    var secndHalfIsMatch = winningRegex.IsMatch(secondHalf);

                    if (jackpotRegex.IsMatch(currentTicket))
                    {
                        var match = jackpotRegex.Match(currentTicket);
                        Console.WriteLine($"ticket \"{currentTicket}\" - 10{match.Value[0]} Jackpot!");
                    }
                    else if (firstHalfIsMatch && secndHalfIsMatch)
                    {
                        var firstMatch = winningRegex.Match(firstHalf);
                        var secondMatch = winningRegex.Match(secondHalf);

                        if (firstMatch.Value[0] == secondMatch.Value[0])
                        {
                            if (firstMatch.Value.Length >= secondMatch.Value.Length)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {secondMatch.Length}{firstMatch.Value[0]}");
                            }
                            else if (firstMatch.Value.Length < secondMatch.Value.Length)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {firstMatch.Length}{firstMatch.Value[0]}");
                            }
                        }
                        else Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                    else Console.WriteLine($"ticket \"{currentTicket}\" - no match");

                }
                else Console.WriteLine("invalid ticket");
            }
        }
    }
}
