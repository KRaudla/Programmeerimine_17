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

            //Dice dice = new Dice();//created class "Dice.cs"  and object
            Dice d6 = new Dice(6,"d6");//input sides '6' and description 'd6'
            Dice d8 = new Dice(8,"d8");

            int sum = 0;//collecting values from loops

            for (int i = 0; i < 3; i++)
            {
                int diceVal = d6.Roll();
                Console.WriteLine($"1{d6.Desc} {diceVal}");
                sum += diceVal;
            }
            for (int i = 0; i < 2; i++)
            {
                int diceVal = d8.Roll();
                Console.WriteLine($"1{d8.Desc} {diceVal}");
                sum += diceVal;
            }
            Console.WriteLine();
            Console.WriteLine($"Total: {sum}");
            Console.ReadLine();
        }
    }
}
