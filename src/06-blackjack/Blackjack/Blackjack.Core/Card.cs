using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Card
    {
        public string Description => Rank +Suit;
        public readonly string Rank;
        public readonly string Suit;
        public readonly int Points;
        

        public Card(string rank, string suit, int points)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Points = points;
        }
    }
}
