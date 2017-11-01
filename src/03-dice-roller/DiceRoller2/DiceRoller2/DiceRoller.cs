using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    class DiceRoller
    {
        //roll the list of dice objects and return list of results public diceroll is a constructor
        public List<DiceRoll> Roll(List<Dice> dices)

        {
            var results = new List<DiceRoll>();//list for saving results

            //loop through the dices
            foreach (var dice in dices)
            {
                //roll each dice
                var diceValue = dice.Roll();//roll method returns int

                //add new object to list. Get description from rolled dice object and value from dice roll method
                results.Add(new DiceRoll(dice.Desc, diceValue));
            }

            //return list of objects
            return results;
        }
    }
}
