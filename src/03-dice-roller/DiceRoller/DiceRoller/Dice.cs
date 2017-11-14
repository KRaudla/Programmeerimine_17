using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Dice
    {
        public int Sides { get; }
        public string Description { get; }

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Description = description;
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
