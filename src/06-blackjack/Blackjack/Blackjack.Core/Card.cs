using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Card
    {
        public string Description => _rank +_suit;
        private readonly string _rank;
        private readonly string _suit;
        private readonly int _points;
        

        public Card(string rank, string suit, int points)
        {
            this._rank = rank;
            this._suit = suit;
            this._points = points;
        }
    }
}
