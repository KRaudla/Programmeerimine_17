using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Parsing_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            string firstString = Console.ReadLine();
            // string to number
            int firstInt = int.Parse(firstString);
            Console.WriteLine("Sisesta teine number:");
            string secondString = Console.ReadLine();
            // string to number
            int secondInt = int.Parse(secondString);

            Console.WriteLine(firstInt + secondInt);

            Console.ReadLine();






        }




    }
}
