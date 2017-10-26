using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a discount calculator"+"\n"+"Please enter the amount of purchase: " );
            //ask amount
            int amount = int.Parse(Console.ReadLine());

            //save values from if statements
            int discountPerc = 0;
            double resultAmount = 0;

            if (amount > 50 && amount <= 250)
            {
                discountPerc = 5;
                resultAmount = amount - amount * 0.05;
            }
            if (amount > 250 && amount <= 500)
            {
                discountPerc = 10;
                resultAmount = amount - amount * 0.1;
            }
            if (amount > 500)
            {
                discountPerc = 20;
                resultAmount = amount - amount * 0.2;
            }
            if (amount <= 50)
            {
                discountPerc = 0;
                resultAmount = amount;
            }
            Console.WriteLine($"You entered: { amount}. You got {discountPerc}% discount, so you have to pay {resultAmount}.");
            Console.ReadLine();
        }
      
    }
}
