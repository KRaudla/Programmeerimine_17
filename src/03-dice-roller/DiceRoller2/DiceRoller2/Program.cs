using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    class Program
    {
        static void Main(string[] args)
        {

            // ask user input and make string array
            Console.WriteLine("Insert command and dices to roll.");
            Console.WriteLine();
            Console.Write(">");
            string [] inputArray = Console.ReadLine().Split(null);

            //pass this array to parser method and return list of dices
            DiceRollCommandParser parser = new DiceRollCommandParser();
            List<Dice> dices = parser.ParseDices(inputArray);

            //make list of dices - manual input
            //List<Dice> dices = new List<Dice> {Dice.D6,Dice.D6,Dice.D6,Dice.D8,Dice.D8 };

            //diceroller object
            DiceRoller diceRoller = new DiceRoller();

            //roll the dices to get results
            List<DiceRoll> results = diceRoller.Roll(dices);
            
            //echo results
            foreach(var r in results)
            {
                Console.WriteLine($"1{ r.Description}, { r.Value}");
            }
            Console.WriteLine();
            //sum the dice values
            Console.WriteLine($"Sum: {results.Sum(x => x.Value)}");

            Console.WriteLine();
            Console.Write("> ");
            Console.ReadLine();

        }
    }
}
