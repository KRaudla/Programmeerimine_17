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
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine();

            DiceRoller diceRoller = new DiceRoller();//diceroller object

            // make new list of dices. Dices are pre-defined with sides and description.
            List<Dice> dices = new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8 };

            //1) Make new diceRolls list to save results. 
            //2) Roll the dice objects. Each dice has a parameter (sides, description).
            List<DiceRoll> diceRolls = diceRoller.Roll(dices);//Roll will return the List of results

            foreach (var diceRoll in diceRolls)//loop through the list of diceroll results
            {
                //for each dice, show the result
                Console.WriteLine($"1{diceRoll.DiceDesc}: {diceRoll.Value}");
            }
            //blank line
            Console.WriteLine();
            //sum the the result of rolls
            Console.WriteLine($"Roll total: {diceRolls.Sum(diceResult => diceResult.Value)}");
            Console.WriteLine();
            Console.Write("> ");

            Console.ReadLine();
        }

        

       
    }
}
