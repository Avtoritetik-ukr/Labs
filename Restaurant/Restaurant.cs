using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Restaurant : Manager
    {
        private List<Menu> menu = new List<Menu>();
        private List<Order> orders = new List<Order>();
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
                Console.WriteLine($"[{item.ID}]");
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
        public void AddItemToOrder(int orderId, int ItemID)
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
                if (item.ID == ItemID)
                {
                    foundItem = item;
                    break;
                }
            }
            if (foundOrder != null && foundItem != null)
            {
                if (foundOrder.Status == Status.Paid)
                {
                    Console.WriteLine("Cannot add items to a paid order.");
                    return;
                }
                foundOrder.AddItem(foundItem);
                if (foundOrder.Status == Status.New)
                {
                    foundOrder.Status = Status.Cooking;
                }
            }
            else
            {
                Console.WriteLine("Order or item ID not found.");
            }
        }
        public void MarkOrderAsReady(int orderID)
        {
            Order foundOrder = null;
            foreach (var order in orders)
            {
                if (order.Id == orderID)
                {
                    foundOrder = order;
                    break;
                }
            }
            if (foundOrder != null)
            {
                if (foundOrder.Status == Status.Cooking)
                {
                    foundOrder.Status = Status.Ready;
                    Console.WriteLine($"Order #{foundOrder.Id} is now ready.");
                }
                else if (foundOrder.Status == Status.Ready)
                {
                    Console.WriteLine($"Order #{foundOrder.Id} is ready");
                }
                else if (foundOrder.Status == Status.Paid)
                {
                    Console.WriteLine($"Order #{foundOrder.Id} is paid");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Order not found");
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
            bool foundActive = false;
            Console.WriteLine("---- Active Orders ----");
            foreach (var order in orders)
            {
                if (order.Status != Status.Paid)
                {
                    order.PrintOrder();
                    foundActive = true;
                }
            }
            if (!foundActive)
            {
                Console.WriteLine("No active orders.");
            }
        }
    }
}
