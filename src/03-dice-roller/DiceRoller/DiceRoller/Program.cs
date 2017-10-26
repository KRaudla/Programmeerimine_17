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

            Dice diceObject = new Dice(); //Creating new object: class name 'Dice', object name' diceObject = new class name.


            Console.WriteLine(diceObject.Roll(6));
            Console.WriteLine(diceObject.Roll(6));
            Console.WriteLine(diceObject.Roll(6));
            Console.WriteLine(diceObject.Roll(8));
            Console.WriteLine(diceObject.Roll(8));


            Console.ReadLine();
        }
    }
}
