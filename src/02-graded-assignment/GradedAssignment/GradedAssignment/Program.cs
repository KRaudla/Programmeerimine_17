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
            Console.WriteLine("This is a discount calculator"+"\n"+"Please enter the amount: " );
               //ask amount
            int amount = int.Parse(Console.ReadLine());

            int discount = 0;
            int discountamount = 0;

            if (amount <= 50)
            {
                discount = 5;
                discountamount=(amount*5)/100;
            }
            else if (amount>50 & amount <=250)
            {
                discount = 10;
                discountamount = (amount * 5) / 100;
            }
            // in progress here


           
        }
    }
}
