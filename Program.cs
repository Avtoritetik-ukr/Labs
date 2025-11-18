namespace Restaurant
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Manager restaurant = new Restaurant();
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n--- RESTAURANT SYSTEM ---");
                Console.WriteLine("1. Show Menu");
                Console.WriteLine("2. Create Order");
                Console.WriteLine("3. Add Item to Order");
                Console.WriteLine("4. Show All Orders");
                Console.WriteLine("5. Pay & Close Order");
                Console.WriteLine("0. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        restaurant.ShowMenu();
                        break;
                    case "2":
                        Console.Write("Enter Table Number: ");
                        if (int.TryParse(Console.ReadLine(), out int table))
                            restaurant.CreateOrder(table);
                        break;
                    case "3":
                        Console.Write("Enter Order ID: ");
                        int.TryParse(Console.ReadLine(), out int oId);
                        Console.Write("Enter Item Name: ");
                        string name = Console.ReadLine();
                        restaurant.AddItemToOrder(oId, name);
                        break;
                    case "4":
                        restaurant.ShowAllOrders();
                        break;
                    case "5":
                        Console.Write("Enter Order ID to close: ");
                        int.TryParse(Console.ReadLine(), out int cId);
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
