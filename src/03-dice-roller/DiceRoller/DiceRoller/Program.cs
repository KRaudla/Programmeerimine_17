using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert command and dices to roll.");
            Console.WriteLine();
            Console.Write(">");
            string inputCommand = Console.ReadLine();

            //pass string value to parser method and return list of dices
            DiceRollCommandParser parser = new DiceRollCommandParser();
            List<Dice> dices = parser.ParseDices(inputCommand);
            
            //roll the dices to get results
            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> results = diceRoller.Roll(dices);

            foreach (var result in results)
            {
                Console.WriteLine($"1{ result.Description}, { result.Value}");
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
