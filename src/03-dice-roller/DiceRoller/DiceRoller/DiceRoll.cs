using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRoll
    {
        public string DiceDesc { get; }

        public int Value { get; }

        public DiceRoll(string diceDescription, int value)
        {
            this.DiceDesc = diceDescription;
            this.Value = value;
        }



    }
}
