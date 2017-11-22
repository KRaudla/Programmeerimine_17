using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>(52);
        private static Random _random { get; } = new Random();
        private string[] _suits = new string[] { "♠", "♥", "♣", "♦" };
        private string[] _ranks = new string[] { "A","2","3","4","5","6","7","8","9","10","J","Q","K" };

        

        public Deck()
        {
            AddCards();
        }


        public void AddCards()
        {
            foreach (var suit in _suits)
            {
                foreach (var rank in _ranks)
                {
                    if (rank == "J"|| rank == "Q" || rank == "K")
                    {
                        this._cards.Add(new Card(rank.ToString(),suit,10,false));
                    }
                    else if (rank == "A")
                    {
                        this._cards.Add(new Card(rank.ToString(), suit, 1, false));
                    }
                    else
                    {
                        this._cards.Add(new Card(rank, suit, int.Parse(rank), false));
                    }
                }
            }
        }

        public Card TakeCard()
        {
            
            var selectedCardIndex = _random.Next(_cards.Count);
            var selectedCard = _cards.ElementAt(selectedCardIndex);
            _cards.RemoveAt(selectedCardIndex);
            return selectedCard;
        }
    }
}