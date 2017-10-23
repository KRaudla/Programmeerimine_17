using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_guess_number_while_true
{
    class Program
    {
        static void Main(string[] args)
        {
            //generate random number between 0-100
            Random rndGenerator = new Random();
            int gnrNumber = rndGenerator.Next(1, 101);
            while (true)
            {
                Console.WriteLine("Paku üks number vahemikus 0-100?");
                //ask user input
                string input = Console.ReadLine();

                //Parse user input
                int userInput = int.Parse(input);

                if (userInput<gnrNumber)
                {
                    Console.WriteLine("Sinu number on väiksem");
                }
                if (userInput > gnrNumber)
                {
                    Console.WriteLine("Sinu number on suurem");
                }
                if (userInput == gnrNumber)
                {
                    Console.WriteLine("bingo");
                    break;
                }
                
                //Console.ReadKey();


            }


        }
    }
}
