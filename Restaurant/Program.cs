namespace Restaurant
{
    class Program
    {
        static void Main(string[] agrs)
        {
            IManager restaurant = new Restaurant();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n--- RESTAURANT SYSTEM ---");
                Console.WriteLine("1. Show Menu");
                Console.WriteLine("2. Create Order");
                Console.WriteLine("3. Add Item to Order");
                Console.WriteLine("4. Show All Orders");
                Console.WriteLine("5. Mark Order as Ready");
                Console.WriteLine("6. Pay & Close Order");
                Console.WriteLine("0. Exit");
                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        restaurant.ShowMenu();
                        break;
                    case "2":
                        Console.Write("Enter Table Number: ");
                        int table = int.Parse(Console.ReadLine()!);
                        restaurant.CreateOrder(table);
                        break;
                    case "3":
                        Console.Write("Enter Order ID: ");
                        int oId = int.Parse(Console.ReadLine()!);
                        Console.Write("Enter Dis ID: ");
                        int itemID = int.Parse(Console.ReadLine()!);
                        restaurant.AddItemToOrder(oId, itemID);
                        break;
                    case "4":
                        restaurant.ShowAllOrders();
                        break;
                    case "5":
                        Console.Write("Enter Order ID to mark Ready: ");
                        int readyID = int.Parse(Console.ReadLine()!);
                        restaurant.MarkOrderAsReady(readyID);
                        break;
                    case "6":
                        Console.Write("Enter Order ID to close: ");
                        int cId = int.Parse(Console.ReadLine()!);
                        restaurant.CloseOrder(cId);
                        break;
                    case "0":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        break;
                }
            }
        }
    }
}
