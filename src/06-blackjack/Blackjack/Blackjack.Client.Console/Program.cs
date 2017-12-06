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

            //2 cards
            deck.Deal(player.PlayerHand,2);
            deck.Deal(dealer.DealerHand,2);
            //take new card or finish?

            while (true)
            {
                Console.WriteLine("1 - Take another card");
                Console.WriteLine("2 - Finish");
                var answer = Console.ReadKey();
                if (answer.KeyChar == 1)
                {
                    Console.WriteLine("taking antoher card");
                    break;
                }
                if (answer.KeyChar == 2)
                {
                    Console.WriteLine("finishing the game");
                    break;
                }
            }

            //1 more
            deck.Deal(player.PlayerHand, 1);
            deck.Deal(dealer.DealerHand, 1);

            //1 more for player
            deck.Deal(player.PlayerHand, 2);
            
            //finish
            //while dealer has 17 or less then give on card to dealer

            



            var playertotal = player.PlayerHand.ShowPoints();
            var dealertotal = dealer.DealerHand.ShowPoints();

            /* we have 2 players
            - dealer deals 2 cards for player and dealer. Dealer cards must be hidden
            - player knows, to take new card or finish
            - after finish dealer shows his cards
            - who wins?

            */



            //Console.WriteLine($"You have been dealt: {deck.TakeCard(player).Description} {deck.TakeCard(player).Description}");
            Console.WriteLine();

            //Dealer: If the total is 17 or more, he must stand. If the total is 16 or under, he must take a card. 
            //Console.WriteLine($"House has been dealt: {GetCardDescription(deck.Next())}, {GetCardDescription(deck.Next())}");
            
            
            Console.WriteLine("House has been dealt [?]");
            Console.WriteLine();

            Console.WriteLine("Your total: 17");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
