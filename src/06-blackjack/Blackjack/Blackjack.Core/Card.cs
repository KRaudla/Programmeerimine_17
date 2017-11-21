using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Card
    {
        //Fields
        private readonly string _rank;
        private readonly Suit _suit;
        private readonly int _points;

        //Properties
        public string Description => _rank + _suit.GetShortName();
        public bool Hidden { get; set; } 

        public Card(string rank, Suit suit, int points, bool hidden)
        {
            this._rank = rank;
            this._suit = suit;
            this._points = points;
            this.Hidden = Hidden;
            
        }

    }
}
