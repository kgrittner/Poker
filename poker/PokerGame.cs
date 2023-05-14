using CardLibrary.Enums;
using CardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poker
{
    public class PokerGame
    {
        /// <summary>
        /// Checks for a straight flush hand.
        /// </summary>
        /// <remarks>A straight flush hand is 3 cards of the same suit in sequential rank.</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a straight flush; returns false otherwise.</returns>
        private static bool IsStraightFlush(Hand hand)
        {
            return IsFlush(hand) && IsStraight(hand);
        }

        /// <summary>
        /// Checks for a three of a kind hand.
        /// </summary>
        /// <remarks>A three of a kind hand has 3 cards of the same rank</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a three of a kind; returns false otherwise.</returns>
        private static bool IsThreeOfAKind(Hand hand)
        {
            var ranks = new List<Rank>();
            foreach (var card in hand.Cards)
            {
                ranks.Add(card.Rank);
            }

            ranks.Sort();
            return ranks[0] == ranks[1] && ranks[1] == ranks[2];
        }

        /// <summary>
        /// Checks for a straight hand.
        /// </summary>
        /// <remarks>A straight hand is 3 cards of sequential rank.</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a straight; returns false otherwise.</returns>
        private static bool IsStraight(Hand hand)
        {
            var ranks = new List<Rank>();
            foreach (var card in hand.Cards)
            {
                ranks.Add(card.Rank);
            }

            ranks.Sort();
            return ranks[0] + 1 == ranks[1] && ranks[1] + 1 == ranks[2];
        }

        /// <summary>
        /// Checks for the flush hand.
        /// </summary>
        /// <remarks>A flush hand is 3 cards of the same suit.</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a flush; returns false otherwise.</returns>
        private static bool IsFlush(Hand hand)
        {
            var firstSuit = hand.Cards[0].Suit;
            return hand.Cards.TrueForAll(card => card.Suit == firstSuit);
        }

        /// <summary>
        /// Checks for a one pair hand.
        /// </summary>
        /// <remarks>A one pair hand has two cards of the same rank.</remarks>
        /// <param name="hand">The player's hand.</param>
        /// <returns>Returns true if the hand is a one pair; returns false otherwise.</returns>
        private static bool IsPair(Hand hand)
        {
            var ranks = new List<Rank>();
            foreach (var card in hand.Cards)
            {
                ranks.Add(card.Rank);
            }

            ranks.Sort();
            return (ranks[0] == ranks[1] && ranks[1] != ranks[2]) ||
                   (ranks[0] != ranks[1] && ranks[1] == ranks[2]);
        }


        private static int CompareCards(Card card1, Card card2)
        {
            if (card1.Rank > card2.Rank)
                return 1;
            if (card1.Rank < card2.Rank)
                return -1;
            return 0;
        }

        private static int CompareHands(Hand hand1, Hand hand2)
        {
            if (IsStraightFlush(hand1) && !IsStraightFlush(hand2))
                return 1;
            if (IsStraightFlush(hand2) && !IsStraightFlush(hand1))
                return -1;

            if (IsThreeOfAKind(hand1) && !IsThreeOfAKind(hand2))
                return 1;
            if (IsThreeOfAKind(hand2) && !IsThreeOfAKind(hand1))
                return -1;

            if (IsStraight(hand1) && !IsStraight(hand2))
                return 1;
            if (IsStraight(hand2) && !IsStraight(hand1))
                return -1;

            if (IsFlush(hand1) && !IsFlush(hand2))
                return 1;
            if (IsFlush(hand2) && !IsFlush(hand1))
                return -1;

            if (IsPair(hand1) && !IsPair(hand2))
                return 1;
            if (IsPair(hand2) && !IsPair(hand1))
                return -1;

            hand1.Cards.Sort(CompareCards);
            hand2.Cards.Sort(CompareCards);

            for (int i = hand1.Cards.Count - 1; i >= 0; i--)
            {
                int compare = CompareCards(hand1.Cards[i], hand2.Cards[i]);
                if (compare != 0)
                    return compare;
            }

            return 0;
        }

        public static List<int> FindWinningPlayers(List<Player> players)
        {
            var winningPlayers = new List<int>();
            Hand bestHand = players[0].Hand;

            foreach (var player in players)
            {
                var currentHand = player.Hand;
                int compare = CompareHands(currentHand, bestHand);
                if (compare > 0)
                {
                    winningPlayers.Clear();
                    winningPlayers.Add(player.Id);
                    bestHand = currentHand;
                }
                else if (compare == 0)
                {
                    winningPlayers.Add(player.Id);
                }
            }

            return winningPlayers;
        }
    }
}
