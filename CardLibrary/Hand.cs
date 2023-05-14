using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class Hand
    {
        public List<Card> Cards { get; }

        public Hand(string[] cards)
        {
            Cards = new List<Card>();
            foreach (var card in cards)
            {
                Cards.Add(new Card(card));
            }
        }
    }
}
