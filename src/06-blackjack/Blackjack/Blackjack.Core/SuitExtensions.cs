using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    static class SuitExtensions
    {
        public static Char GetShortName(this Suit suit)
        {
            switch (suit)
            {
                case Suit.Club: return 'C';
                case Suit.Diamond: return 'D';
                case Suit.Heart: return 'H';
                case Suit.Spade: return 'S';
                default: throw new InvalidOperationException();

            }
        }


    }
}
