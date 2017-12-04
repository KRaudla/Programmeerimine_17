﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Core
{
    public class Deck
    {
        private readonly List<Card> _cards = new List<Card>(52);
        private string[] _suits = new string[] { "♠", "♥", "♣", "♦" };
        private string[] _ranks = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        public Deck()
        {
            PopulateDeck52();
        }

        private void PopulateDeck52()
        {
            foreach (var suit in _suits)
            {
                foreach (var rank in _ranks)
                {
                    if (rank == "J" || rank == "Q" || rank == "K")
                    {
                        this._cards.Add(new Card(rank.ToString(), suit, 10));
                    }
                    else if (rank == "A")
                    {
                        //The Ace is always valued at 11. When hand going over 21, Ace is valued as 1.
                        this._cards.Add(new Card(rank.ToString(), suit, 11));
                    }
                    else
                    {
                        this._cards.Add(new Card(rank, suit, int.Parse(rank)));
                    }
                }
            }
        }

        private static Random _random { get; } = new Random();

        public void DealCards(Player player)
        {
            List<Card> dealedCards = new List<Card>();
            //first two cards to deal
            for (int i = 0; i < 2; i++)
            {
                var selectedCardIndex = _random.Next(_cards.Count);
                var dealedCard = _cards.ElementAt(selectedCardIndex);
                _cards.RemoveAt(selectedCardIndex);
                player.TakeDealedCard(dealedCard);
            }
            
        }      
    }
}