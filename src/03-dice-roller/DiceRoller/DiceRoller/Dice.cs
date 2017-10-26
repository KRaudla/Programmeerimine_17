using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    

    public class Dice
    {

        //define the members of the class. Public, Private, Static

        /*taking random initialization out from the 'Roll' method, 
         * because we should initialize it only once - when the class is constructed */
        private Random Rnd { get; } = new Random();//'get' or 'set' is the keywords to expose the variables in the controlled way

        public int Roll(int sides)//Return Method: input parameter = sides
        {
            //Random rnd = new Random();// creating 'rnd' object

            //keyword 'this' refers to the current instance of the class
            return this.Rnd.Next(1, sides + 1);//max value is exclusive, so we have to add +1
        }

    }
}
