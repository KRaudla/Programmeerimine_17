using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Dealer
    {
        public Hand DealerHand { get; }

        public Dealer()
        {
            this.DealerHand = new Hand();
        }
    }
}
