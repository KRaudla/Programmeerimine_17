namespace Blackjack.Client.Console
{
    using Blackjack.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "♠♥♣♦ Blackjack";
            Console.WriteLine("Welcome to the game of Blackjack");
            Console.WriteLine("-------------------------------------------------");
            

            var deck = new Deck();
            var player = new Player();
            var dealer = new Dealer();

            //2 cards
            deck.Deal(player.PlayerHand);
            deck.Deal(player.PlayerHand);
            deck.Deal(dealer.DealerHand);
            deck.Deal(dealer.DealerHand);
            //take new card or finish?
            Console.WriteLine($"You have been dealt 2 cards:{player.PlayerHand.ShowCards().Select(card => card.Description).Aggregate((card, next) => next + ' ' + card)}");

            Console.WriteLine($"You have {player.PlayerHand.ShowPoints()} points");
            Console.WriteLine("-------------------------------------------------");
            while (true)
            {
                Console.WriteLine("Choose 'N' - Take another card");
                Console.WriteLine("Choose 'F' - Finish");
                Console.Write(">");
                var answer = Console.ReadKey();
                Console.WriteLine();

                if (answer.Key==ConsoleKey.N)
                {
                    Console.WriteLine("taking antoher card");
                    break;
                }

                if (answer.Key == ConsoleKey.F)
                {
                    Console.WriteLine("finishing the game");

                    break;
                }
            }

            //Dealer: If the total is 17 or more, he must stand. If the total is 16 or under, he must take a card. 
            //Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            
            
            Console.WriteLine("House has been dealt [?]");
            

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
