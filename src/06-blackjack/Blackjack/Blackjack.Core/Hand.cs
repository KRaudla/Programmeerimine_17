using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Hand
    {

        private List<Card> cardsInHand = new List<Card>();

        public void Take(Card card) => this.cardsInHand.Add(card);
        public int ShowPoints() => this.cardsInHand.Sum(c => c.Points);
        public string ShowCards() => cardsInHand.Select(card => card.Description).Aggregate((card, next) => next + ' ' + card);
        public void ClearHand()
        {
            cardsInHand.Clear();

        }
    }
}
