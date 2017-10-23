using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Printing_out_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere, palun sisesta oma nimi:");
            string name = Console.ReadLine();
            Console.WriteLine("Sinu nimi on: " + name);
            Console.ReadLine();
            
        }
    }
}
