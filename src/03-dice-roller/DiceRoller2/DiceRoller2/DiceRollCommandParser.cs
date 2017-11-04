using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller2
{
    public class DiceRollCommandParser
    {

        public List<Dice> ParseDices(string[] inputArray)

        {
            var results = new List<Dice>();//save dice objects to return

            if (inputArray != null && inputArray[0] == "/roll")
            {
                // loop through the array, starting from 2nd element
                foreach (string element in inputArray.Skip(1))
                {
                    //split neccessary information from element
                    int numOfDices = int.Parse(element[0].ToString());
                    string description = element.Substring(1);
                    int sides = int.Parse(element.Substring(2));
                    
                    //add dice objects to results list
                    for(int i = 0; i < numOfDices; i++)
                    {
                        results.Add(new Dice(sides,description));
                    }
                }   
            }
            return results;//return the list of dices
        }          
    }
}
