using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        //class variables
        public int Sides { get; }
        public string Desc { get; }

        //lets define the dice constructor
        public Dice(int sides, string desc)
        {
            this.Sides = sides;
            this.Desc = desc;
        }
        //make random for roll method
        private static Random Rnd { get; } = new Random();
        // roll method to return randomly generated number
        public int Roll()
        {
            return Dice.Rnd.Next(1, this.Sides + 1);
        }
    }
}
