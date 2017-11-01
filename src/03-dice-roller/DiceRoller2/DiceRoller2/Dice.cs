using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    class Dice
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

        //Lets define some default dices, with sides 6 and 8.
        public static Dice D6 = new Dice(6, "db6");
        public static Dice D8 = new Dice(8, "db8");

        //make random for roll method
        private static Random Rnd { get; } = new Random();
        // roll method to return randomly generated number
        public int Roll()
        {
            return Dice.Rnd.Next(1, this.Sides + 1);
        }

    }
}
