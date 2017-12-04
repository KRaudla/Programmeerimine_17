namespace Blackjack.Client.Console
{
    using Blackjack.Core;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "♠♥♣♦ Blackjack";
            Console.WriteLine("Welcome to the game of Blackjack");
            Console.WriteLine();

            var deck = new Deck();
            var player = new Player();
            var dealer = new Dealer();

            deck.DealCards();

            
            
            /* we have 2 players
            - dealer deals 2 cards for player and dealer. Dealer cards must be hidden
            - player knows, to take new card or finish
            - after finish dealer shows his cards
            - who wins?

            */
            var dealedCards = deck.DealCards();


            Console.WriteLine($"You have been dealt: {deck.TakeCard(player).Description} {deck.TakeCard(player).Description}");
            Console.WriteLine();

            //Dealer: If the total is 17 or more, he must stand. If the total is 16 or under, he must take a card. 
            //Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            
            
            Console.WriteLine("House has been dealt [?]");
            Console.WriteLine();

            Console.WriteLine("Your total: 17");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static string GetCardDescription(Card card )
        {
            return card.Hidden ? "?" : card.Description;
        }
        

    }
}
