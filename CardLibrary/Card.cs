using CardLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Card
    {
        public Rank Rank { get; }
        public Suit Suit { get; }

        public Card(string rankSuit)
        {
            Rank = ParseRank(rankSuit[0]);
            Suit = ParseSuit(rankSuit[1]);
        }


        private static Rank ParseRank(char rankChar)
        {
            if (char.IsDigit(rankChar))
                return (Rank)int.Parse(rankChar.ToString());

            switch (rankChar)
            {
                case 'T':
                    return Rank.Ten;
                case 'J':
                    return Rank.Jack;
                case 'Q':
                    return Rank.Queen;
                case 'K':
                    return Rank.King;
                case 'A':
                    return Rank.Ace;
                default:
                    throw new ArgumentException("Invalid card rank: " + rankChar);
            }
        }

        private static Suit ParseSuit(char suitChar)
        {
            switch (suitChar)
            {
                case 'h':
                    return Suit.Hearts;
                case 'd':
                    return Suit.Diamonds;
                case 's':
                    return Suit.Spades;
                case 'c':
                    return Suit.Clubs;
                default:
                    throw new ArgumentException("Invalid card suit: " + suitChar);
            }
        }
    }
}
