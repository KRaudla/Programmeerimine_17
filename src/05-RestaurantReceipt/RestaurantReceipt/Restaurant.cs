using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReceipt
{
    class Restaurant
    {

        public string Name { get; }
        public string Street { get; }

        public Restaurant(string name, string street)
        {
            this.Name = name;
            this.Street = street;
        }

        public Receipt GetReceipt(Tab tab)
        {
            return new Receipt(this.Name, this.Street, tab);
        }
    }
}
