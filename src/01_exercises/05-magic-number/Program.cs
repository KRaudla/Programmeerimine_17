using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_magic_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Paku üks number vahemikus 0-100?");
            //ask user input
            string input =  Console.ReadLine();
            
            //Parse user input
            int userInput = int.Parse(input);

            //generate random number between 0-100
            Random rndGenerator = new Random();
            int gnrNumber = rndGenerator.Next(1, 101);
            //int gnrNumber = 20;
            // compare user input with generated number

            if (userInput == gnrNumber)
            {
                Console.WriteLine("bingo");
            }
            else if (userInput > gnrNumber)
            {
                Console.WriteLine("Sinu sisestatud number on suurem");
            }
            else if (userInput < gnrNumber)
            {
                Console.WriteLine("Sinu sisestatud number on väiksem");
            }
            else
            {
            }

            Console.ReadLine();
        }
    }
}
