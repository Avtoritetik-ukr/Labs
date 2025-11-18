using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Order
    {
        public static int IdCounter = 1;
        public int Id { get; set; }
        public int TableNumber { get; set; }
        public Status Status { get; set; }
        public List<Menu> Items = new List<Menu>();
        public Order(int tableNumber)
        {
            Id = IdCounter++;
            TableNumber = tableNumber;
            Status = Status.New;
        }
        public void AddItem(Menu item)
        {
            Items.Add(item);
            Console.WriteLine($"Add: {item.Name}");
        }
        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }
        public void PrintOrder()
        {
            Console.WriteLine($"\n---- Order #{Id} (Table {TableNumber}) ----");
            Console.WriteLine($"Status: {Status}");
            foreach (var item in Items)
            {
                if (item is Drink drink)
                {
                    Console.WriteLine($"Drink: {drink.Name}({drink.VolumeInLiters}L)- {drink.Price}");
                }    
                else if (item is Dish dish)
                {
                    Console.WriteLine($"Dish: {dish.Name} ({dish.WeithInGrams}g)-{dish.Price}");
                }
                else
                {
                    Console.WriteLine($"{item.Name}-{item.Price}");
                }
            }
            Console.WriteLine($"Amount due: {CalculateTotal()}grn.\n");
        }
    }
}
