using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Restaurant : Manager
    {
        public List<Menu> menu = new List<Menu>();
        public List<Order> orders = new List<Order>();
        public Restaurant()
        {
            menu.Add(new Dish("Pasta", 120, 250));
            menu.Add(new Dish("Steak", 300, 400));
            menu.Add(new Drink("Coca-Cola", 50, 0.5, false));
            menu.Add(new Drink("Wine", 150, 0.2, true));
            menu.Add(new Dish("Salad", 80, 150));
        }
        public void ShowMenu()
        {
            Console.WriteLine("---- Menu ----");
            foreach (var item in menu)
            {
                Console.WriteLine(item.GetDescription());
            }
            Console.WriteLine("--------------\n");
        }
        public void CreateOrder(int tableNumber)
        {
            var order = new Order(tableNumber);
            orders.Add(order);
            Console.WriteLine($"Created Order #{order.Id}.");
        }
        public void AddItemToOrder(int orderId, string itemName)
        {
            Order foundOrder = null;
            foreach (var order in orders)
            {
                if (order.Id == orderId)
                {
                    foundOrder = order;
                    break;
                }
            }
            Menu foundItem = null;
            foreach (var item in menu)
            {
                if (item.Name.ToLower() == itemName.ToLower())
                {
                    foundItem = item;
                    break;
                }
            }
            if (foundOrder != null && foundItem != null)
            {
                foundOrder.AddItem(foundItem);
                if (foundOrder.Status == Status.New)
                {
                    foundOrder.Status = Status.Cooking;
                }
            }
            else
            {
                Console.WriteLine("Order or item not found.");
            }
        }
        public void CloseOrder(int orderId)
        {
            Order foundOrder = null;
            foreach (var order in orders)
            {
                if (order.Id == orderId)
                {
                    foundOrder = order;
                    break;
                }
            }
            if (foundOrder != null)
            {
                foundOrder.Status = Status.Paid;
                Console.WriteLine($"Order #{foundOrder.Id} is closed and paid.");
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
        }
        public void ShowAllOrders()
        {
            Console.WriteLine("---- Active Orders ----");
            foreach (var order in orders)
            {
                order.PrintOrder();
            }
        }
    }
}
