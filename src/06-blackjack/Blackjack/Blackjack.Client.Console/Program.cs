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

            var player = "player";
            var dealer = "dealer";

            var deck = new Deck();

            Console.WriteLine($"You have been dealt: {deck.TakeCard(player).Description} {deck.TakeCard(player).Description}");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("----Choose 1 - Take antoher card");
                Console.WriteLine("----Choose 2 - Finish");
                Console.WriteLine();

                var answer = int.Parse(Console.ReadLine());
                if (answer==1)
                {
                    Console.WriteLine($"You have been dealt: {deck.TakeCard(player).Description}");
                    Console.WriteLine($"Your hand: {deck.ShowCards()}");
                }
                else if (answer==2)
                {
                    Console.WriteLine("While-loop break");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid operator");
                    break;
                }
            }
            
            
            

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
