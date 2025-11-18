using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public interface Manager
    {
        void ShowMenu();
        void CreateOrder(int tableNumber);
        void AddItemToOrder(int orderId, string itemName);
        void CloseOrder(int orderId);
        void ShowAllOrders();
    }
}
