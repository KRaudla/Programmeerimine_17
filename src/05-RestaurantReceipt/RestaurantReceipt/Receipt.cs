using System;
using System.Linq;
using System.Text;

namespace RestaurantReceipt
{
    public class Receipt
    {

        private string Name;
        private string Street;
        private Tab Tab;

        public Receipt(string name, string street, Tab tab)
        {
            this.Name = name;
            this.Street = street;
            this.Tab = tab;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat($"{this.Name}\n{this.Street}\n");
            builder.AppendFormat("-----------------------------------------\n");
            foreach (var item in this.Tab.Tabs)
            {
                builder.AppendFormat($"Price of food item: {item:F2}\n");
            }

            var subtotal = this.Tab.Tabs.Sum(x => (x));
            var graduity = subtotal * 0.15;
            builder.AppendFormat("-----------------------------------------\n");
            builder.AppendFormat($"{subtotal:F2}\n");
            builder.AppendFormat($"15.00 % Graduity:{graduity:F2}\n");
            builder.AppendFormat($"Total: €{subtotal-graduity:F2}\n");

            //Console.WriteLine($"Subtotal: {total}");
            //Console.WriteLine($"15.00 % Graduity:{total * 0.15:F2}");
            //Console.WriteLine($"Total: €{total - total * 0.15:F2}");

            
            return builder.ToString();
        }


    }
}