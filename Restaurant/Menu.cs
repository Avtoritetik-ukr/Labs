using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Menu
    {
        public static int ItemID = 1;
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Menu(string name, decimal price)
        {
            ID = ItemID++;
            Name = name;
            Price = price;
        }
        public abstract string GetDescription();
    }
}
