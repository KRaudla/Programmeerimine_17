using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    public class Dice
    {
        //class variables
        public int Sides { get; }
        public string Desc { get; }

        //lets define the dice constructor
        public Dice (int sides, string desc)
        {
            this.Sides = sides;
            this.Desc = desc;
        }

        //Lets define some default dices
        //public static Dice D4 = new Dice(4, "d4");
        //public static Dice D6 = new Dice(6, "d6");
        
        //make random for roll method
        private static Random Rnd { get; } = new Random();
        // roll method to return randomly generated number
        public int Roll()
        {
            return Dice.Rnd.Next(1, this.Sides + 1);
        }

    }
}
