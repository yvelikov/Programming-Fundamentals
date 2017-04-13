namespace _05.HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HandsOfCards
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split(':');

            var handsOfCards = new Dictionary<string, HashSet<string>>();

            var cardPower = new Dictionary<string, int>();

            cardPower["2"] = 2;
            cardPower["3"] = 3;
            cardPower["4"] = 4;
            cardPower["5"] = 5;
            cardPower["6"] = 6;
            cardPower["7"] = 7;
            cardPower["8"] = 8;
            cardPower["9"] = 9;
            cardPower["10"] = 10;
            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            var cardType = new Dictionary<string,int>();

            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;

            while (entry[0] != "JOKER")
            {
                var name = entry[0];
                var hand = entry[1].Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (!handsOfCards.ContainsKey(name))
                {
                    handsOfCards[name] = new HashSet<string>();
                }
                foreach (var card in hand)
                {
                    handsOfCards[name].Add(card);
                }

                entry = Console.ReadLine().Split(':');
            }

            foreach (var hand in handsOfCards)
            {
                var sum = 0;
                Console.Write($"{hand.Key}: ");
                var cardsList = new List<string>();

                foreach (var card in hand.Value)
                {
                    cardsList.Add(card);
                }

                for (int i = 0; i < cardsList.Count; i++)
                {
                    foreach (var power in cardPower)
                    {
                        foreach (var type in cardType)
                        {
                            if (cardsList[i].Contains(power.Key) && cardsList[i].Contains(type.Key))
                            {
                                sum += power.Value * type.Value;
                            }
                        }
                    } 
                }
                Console.WriteLine($"{sum}");
                
            }
        }
    }
}
