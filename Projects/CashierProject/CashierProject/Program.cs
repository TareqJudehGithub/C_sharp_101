namespace CashierProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new objects
            Change cashier = new();
            Order order = new();

            int itemCode;
            int quantity = 0;

            Console.Clear();
            Console.WriteLine("Welcome to Cashier V1.02!\n");
            Thread.Sleep(500);

            do
            {
                Console.WriteLine("PLease select an item from the list below:");

                Console.WriteLine("");
                Console.WriteLine("1. Tea");
                Console.WriteLine("2. Coffee");
                Console.WriteLine("3. Water Bottle");
                Console.WriteLine("4. Chocolate Chip Cookie");
                Console.WriteLine("5. Chocolate Cake");
                Console.WriteLine("6. Full Fat Fresh Milk");

                Console.Write("\nItem code: ");
                itemCode = Convert.ToInt32(Console.ReadLine());

                if (itemCode > 6)
                {
                    Console.WriteLine("Invalid item code!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;

                }
                else if (itemCode == 0) break;

                Thread.Sleep(250);
                Console.Write("Quantity: ");
                quantity = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(500);
                Console.Clear();

                if (quantity > 0)
                {
                    order.CalculateOrder(itemCode, quantity);
                    Thread.Sleep(250);

                    Console.WriteLine("\nAdd another item, or enter 0 to finish order:");
                    Thread.Sleep(500);
                }
                else
                {
                    Thread.Sleep(500);
                    Console.WriteLine("Invalid quantity entry: Quantity has to be 1 or greater.");
                    Console.Clear();
                }
            }
            while (itemCode != 0);

            double orderTotal = order.CalculateOrder(itemCode, quantity);

            if (orderTotal > 0)
            {
                // ask user for cash

                double cashReceived;

                do
                {
                    Console.WriteLine($"Your order total is: {orderTotal:C}");
                    Console.WriteLine("");

                    Console.Write("Cash received: ");
                    cashReceived = Convert.ToDouble(Console.ReadLine());

                    if (cashReceived > orderTotal) cashier.CalculateChange(cashReceived, orderTotal);
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Not enough money!");

                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                }
                while (cashReceived < orderTotal);

            }

        }
    }
}