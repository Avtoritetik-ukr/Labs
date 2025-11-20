using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Drink : Menu
    {
        public double VolumeInLiters { get; set; }
        public bool IsAlcoholic { get; set; }
        public Drink(string name, decimal price, double volumeLiters,  bool isAlcoholic) : base(name, price)
        {
            VolumeInLiters = volumeLiters;
            IsAlcoholic = isAlcoholic;
        }
        public override string GetDescription()
        {
            string type = IsAlcoholic ? "Alcoholic" : "Non-Alcoholic";
            return $"Drink {Name}({VolumeInLiters}L, {type})-{Price} grn";
        }
    }
}