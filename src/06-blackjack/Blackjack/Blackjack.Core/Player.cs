using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Player
    {
       
        public Hand PlayerHand { get; }

        public Player()
        {
            this.PlayerHand = new Hand();
        }

        
    }
}
