using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {
        //private static Random rnd = new Random();
        private Random Random { get; }
        private int Sides { get; }
        public string Desc { get; }

        public int Roll()
        {
            return Random.Next(1,this.Sides+1);

        }

        //private readonly Random random;
        public Dice(int sides, String desc)
        {
            this.Desc = desc;
            this.Sides = sides;
            this.Random = new Random();
        }
    }
}
