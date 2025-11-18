using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Menu
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Menu(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract string GetDescription();
    }
}
