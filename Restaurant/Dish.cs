using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dish : Menu
    {
        public int WeithInGrams { get; set; }
        public Dish(string name, decimal price, int weithInGrams) : base(name, price)
        {
            WeithInGrams = weithInGrams;
        }
        public override string GetDescription()
        {
            return $"Dish {Name}({WeithInGrams}g)-{Price}grn";
        }
    }
}
