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
            
            

            var deck = new Deck();
            var player = new Player();
            var dealer = new Dealer();

            //Deal 2 cards for player and dealer
            deck.Deal(player.PlayerHand);
            deck.Deal(player.PlayerHand);
            deck.Deal(dealer.DealerHand);
            deck.Deal(dealer.DealerHand);
            //Ask player: take new card or finish?            
            while (true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                //Console.WriteLine("-------------------------------------------------");
                if (player.PlayerHand.ShowPoints() > 21)
                {
                    Console.WriteLine("--------------------YOU LOST---------------------");
                    break;
                }
                Console.WriteLine("Choose 'T' - Take another card");
                Console.WriteLine("Choose 'F' - Finish");
                Console.Write(">");
                
                var answer = Console.ReadKey();
                Console.WriteLine();

                if (answer.Key==ConsoleKey.T)
                {
                    deck.Deal(player.PlayerHand);
                }

                if (answer.Key == ConsoleKey.F)
                {
                    //Dealer: If the total is 16 or under, he must take a card.
                    if (dealer.DealerHand.ShowPoints()<=16)
                    {
                        deck.Deal(dealer.DealerHand);
                    }

                    if (dealer.DealerHand.ShowPoints() < player.PlayerHand.ShowPoints() && player.PlayerHand.ShowPoints()==21)
                    {
                        Console.WriteLine("---------------BLACKJACK - YOU WON---------------");
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");


                    }
                    if (dealer.DealerHand.ShowPoints() > 21 || dealer.DealerHand.ShowPoints() < player.PlayerHand.ShowPoints())
                    {
                        Console.WriteLine("--------------------YOU WON----------------------");
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");


                    }
                    if (dealer.DealerHand.ShowPoints() == player.PlayerHand.ShowPoints())
                    {
                        Console.WriteLine("---------PUSH - player and dealer have the same total----------");
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");

                    }

                    if (dealer.DealerHand.ShowPoints() > player.PlayerHand.ShowPoints())
                    {
                        Console.WriteLine("--------------------YOU LOST---------------------");
                        Console.WriteLine($"Your cards: {player.PlayerHand.ShowCards()} ({player.PlayerHand.ShowPoints()} points)");
                        Console.WriteLine($"Dealer cards: {dealer.DealerHand.ShowCards()} ({dealer.DealerHand.ShowPoints()} points)");


                    }

                    break;
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
