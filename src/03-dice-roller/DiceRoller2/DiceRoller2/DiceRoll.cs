using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    class DiceRoll
    {

        public string Description { get; }
        public int Value { get; }
        //diceroll constructor
        public DiceRoll(string description, int value)
        {
            this.Description = description;
            this.Value = value;
        }
    }
}
