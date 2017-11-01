using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class DiceRoller
    {

        public List<DiceRoll> Roll(List<Dice> dices)// roll method, input is the list of dice objects
        {
            var result = new List<DiceRoll>();//create list to save results.

            foreach (var dice in dices)//loop through list of dices
            {
                //creating list of objects. Roll the Dice to get value of roll (int).
                result.Add(new DiceRoll(dice.Description, dice.Roll()));
            }

            return result;// method will return the results of rolls, the diceroll list.
        }
    }
}
