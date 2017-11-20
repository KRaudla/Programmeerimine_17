using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Restaurant_receipt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");

            var items = new List<Items>();
            
            while (true)
            {
                Console.Write("Enter price of food item [-i to quit]:");
                Console.WriteLine();
                float input = float.Parse(Console.ReadLine());
                

                if (input == -1)
                {
                    break;
                }
                items.Add(new Items(input));
            }


            var total = items.Sum(x => x.Value);
            Console.WriteLine($"Subtotal: {total}");
            Console.WriteLine($"15.00 % Graduity:{total*0.15}");
            Console.WriteLine($"Total: €{total-total*0.15}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }
    }    
}
