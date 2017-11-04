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
        public static Dice D4 = new Dice(4, "d4");
        public static Dice D6 = new Dice(6, "d6");
        public static Dice D8 = new Dice(8, "d8");
        public static Dice D10 = new Dice(10, "d10");
        public static Dice D12 = new Dice(12, "d12");
        public static Dice D14 = new Dice(14, "d14");
        public static Dice D16 = new Dice(16, "d16");
        public static Dice D18 = new Dice(18, "d18");
        public static Dice D20 = new Dice(20, "d20");

        //make random for roll method
        private static Random Rnd { get; } = new Random();
        // roll method to return randomly generated number
        public int Roll()
        {
            return Dice.Rnd.Next(1, this.Sides + 1);
        }

    }
}
