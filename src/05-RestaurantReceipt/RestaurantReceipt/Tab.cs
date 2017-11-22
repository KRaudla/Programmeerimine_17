using System;
using System.Collections.Generic;

namespace RestaurantReceipt
{
    public class Tab
    {
        public List<double> Tabs = new List<double>();
        public void Add(double price)
        {
            Tabs.Add(price);
        }
    }
}