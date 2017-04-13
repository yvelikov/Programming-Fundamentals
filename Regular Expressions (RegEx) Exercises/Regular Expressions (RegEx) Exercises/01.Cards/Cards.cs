using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;


namespace _01.Cards
{
    public class Cards
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"(([JQKA][SHDC])|(10[SHDC])|(\d+[SHDC]))";
            var regex = new Regex(pattern);

            var matches = regex.Matches(inputLine);
            var listOfCards = new List<string>();

            foreach (Match match in matches)
            {
                var currendCard = match.ToString();
                var power = string.Empty;

                for (int i = 0; i < currendCard.Length - 1; i++)
                {
                    power += currendCard[i];
                }

                decimal number;
                bool isNumber = decimal.TryParse(power, out number);
                if (currendCard.Length == 2)
                {
                    if (isNumber)
                    {
                        if (number > 1)
                        listOfCards.Add(currendCard);
                    }
                    else listOfCards.Add(currendCard);
                }

                else if (number <= 10 && number >= 2)
                {
                    listOfCards.Add(currendCard);
                }
            }

            Console.WriteLine(string.Join(", ", listOfCards));
        }
    }
}
