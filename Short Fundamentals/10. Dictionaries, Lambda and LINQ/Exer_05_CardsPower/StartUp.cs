namespace Exer_05_CardsPower
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var cardsPoint = new Dictionary<string, int>();
            {
                cardsPoint["2"] = 2;
                cardsPoint["3"] = 3;
                cardsPoint["4"] = 4;
                cardsPoint["5"] = 5;
                cardsPoint["6"] = 6;
                cardsPoint["7"] = 7;
                cardsPoint["8"] = 8;
                cardsPoint["9"] = 9;
                cardsPoint["10"] = 10;
                cardsPoint["J"] = 11;
                cardsPoint["Q"] = 12;
                cardsPoint["K"] = 13;
                cardsPoint["A"] = 14;
            };

            var cardTypes = new Dictionary<string, int>();
            {
                cardTypes["S"] = 4;
                cardTypes["H"] = 3;
                cardTypes["D"] = 2;
                cardTypes["C"] = 1;
            };

            var cardScores = new Dictionary<string, List<int>>();

            string hand = Console.ReadLine();

            while (hand != "JOKER")
            {
                string[] splittedHand = hand.Split(':');

                string name = splittedHand[0];
                string[] cards = splittedHand[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in cards)
                {
                    string cardPower = card.Substring(0, card.Length - 1);
                    string cardType = card.Substring(card.Length - 1);

                    int sum = cardsPoint[cardPower] * cardTypes[cardType];

                    if (!cardScores.ContainsKey(name))
                    {
                        cardScores[name] = new List<int>();
                    }

                    if (!cardScores[name].Contains(sum))
                    {
                        cardScores[name].Add(sum);
                    }
                }
                hand = Console.ReadLine();
            }

            foreach (var name in cardScores)
            {
                Console.WriteLine("{0}: {1}", name.Key, name.Value.Sum());
            }
        }
    }
}
