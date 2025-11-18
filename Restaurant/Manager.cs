using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public interface Manager
    {
        void MarkOrderAsReady(int orderId);
        void ShowMenu();
        void CreateOrder(int tableNumber);
        void AddItemToOrder(int orderId, int ItemID);
        void CloseOrder(int orderId);
        void ShowAllOrders();
    }
}
