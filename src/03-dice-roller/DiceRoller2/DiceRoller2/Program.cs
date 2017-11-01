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

            Console.WriteLine("> Rolling some Dices...");
            Console.WriteLine();//blank line 

            //diceroller object
            DiceRoller diceRoller = new DiceRoller();
            //make list of dices
            List<Dice> dices = new List<Dice> {Dice.D6,Dice.D6,Dice.D6,Dice.D8,Dice.D8 };
            //roll the dices to get results
            List<DiceRoll> results = diceRoller.Roll(dices);
            //echo results
            foreach(var r in results)
            {
                Console.WriteLine($"1{ r.Description}, { r.Value}");
            }
            //sum the dice values
            Console.WriteLine($"Sum: {results.Sum(x => x.Value)}");

            Console.WriteLine(">");
            Console.ReadLine();

        }
    }
}
