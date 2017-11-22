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

            
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(deck.TakeCard())},{GetCardDescription(deck.TakeCard())}");
            //Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            Console.WriteLine();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("----Choose 1 - take antoher card");
            Console.WriteLine("----Choose 2 - finish");
            Console.WriteLine();
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
