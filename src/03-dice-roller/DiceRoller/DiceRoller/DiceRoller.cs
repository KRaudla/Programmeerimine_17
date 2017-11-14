using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRoller
    {
        public List<DiceRoll> Roll(List<Dice> dices)
        {
            var results = new List<DiceRoll>();
            foreach (var dice in dices)
            {
                //roll each dice, return int
                var diceValue = dice.Roll();
                
                //add new object to list.
                results.Add(new DiceRoll(dice.Description, diceValue));
            }
            return results;
        }
    }
}
