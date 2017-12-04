using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Player
    {

        private List<Card> _playerCards = new List<Card>();
        public void TakeDealedCard(Card dealedCard)
        {
            _playerCards.Add(dealedCard);
        }

    }
}
