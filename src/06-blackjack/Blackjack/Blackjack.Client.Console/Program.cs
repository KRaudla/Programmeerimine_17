namespace Blackjack.Client.Console
{
    using Blackjack.Core;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "♠♥♣♦ Blackjack Game";
            Console.WriteLine("Welcome to the game of Blackjack");
            Console.WriteLine();

            var cards = new List<Card>()
            {
                new Card("4", Suit.Heart, 4,false),
                new Card("6", Suit.Club, 6, false),
                new Card("8", Suit.Spade, 8, false),
                new Card("J", Suit.Diamond, 10, true)
            };

            var deck = new Deck(cards);
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose 1 - take antoher card");
            Console.WriteLine("Choose 2 - finish");

            Console.WriteLine("You have been dealt 4S");
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
