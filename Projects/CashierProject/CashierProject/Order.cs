namespace CashierProject
{
    internal class Order
    {
        // member - Fields
        private double total;


        //  member - Properties
        internal double Total { get; set; }

        // // Instantiate new objects
        Product tea = new Product(code: 1, name: "Tea", price: 1.68);
        Product coffee = new Product(code: 2, name: "Coffee", price: 1.84);
        Product water = new Product(code: 3, name: "Water Bottle", price: 0.55);
        Product cookie = new Product(code: 4, name: "Chocolate Chip Cookie ", price: 0.99);
        Product chocCake = new Product(code: 5, name: "Chocolate Cake", price: 2.22);
        Product milk = new Product(code: 6, name: "Full Fat Milk", price: 1.55);


        //  member -Methods
        internal double CalculateOrder(int code, int quantity)
        {


            if (code == tea.Code || code == coffee.Code || code == water.Code || code == cookie.Code || code == chocCake.Code || code == milk.Code)
            {
                if (code == tea.Code)
                {
                    Total += tea.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({tea.Name} {tea.Price:C}) has been added to your order.");

                    // Console.WriteLine($"Your new total is {Total:C2}");
                    Thread.Sleep(3000);
                }
                else if (code == coffee.Code)
                {
                    Total += coffee.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({coffee.Name} {coffee.Price:C}) has been added to your order.");

                    // Console.WriteLine($"Your new total is {Total:C2}");
                    Thread.Sleep(3000);
                }
                else if (code == water.Code)
                {
                    Total += water.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({water.Name} {water.Price:C}) has been added to your order.");

                    // Console.WriteLine($"Your new total is {Total:C2}");
                    Thread.Sleep(3000);
                }
                else if (code == cookie.Code)
                {
                    Total += cookie.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({cookie.Name} {cookie.Price:C}) has been added to your order.");

                    Thread.Sleep(2000);
                    Console.WriteLine("This item is HIGHLY recommend by Peter!");
                    Thread.Sleep(5000);

                    // Console.WriteLine($"Your new total is {Total:C2}");
                }
                else if (code == chocCake.Code)
                {
                    Total += chocCake.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({chocCake.Name} {chocCake.Price:C}) has been added to your order.");
                    Thread.Sleep(2000);

                    Console.WriteLine("Peter: 'Chocolate CAAKEE!!' ");
                    Thread.Sleep(3000);
                    // Console.WriteLine($"Your new total is {Total:C2}");

                }
                else if (code == milk.Code)
                {
                    Total += milk.Price * quantity;
                    Thread.Sleep(100);
                    Console.WriteLine($"Item: ({milk.Name} {milk.Price:C}) has been added to your order.");

                    Thread.Sleep(3000);
                    Console.WriteLine("Keep this one away from that nasty kitten If wanna enjoy drinking it!");

                    Thread.Sleep(4000);
                    // Console.WriteLine($"Your new total is {Total:C2}");
                }
            }
            else if (code == 0 && quantity > 0)
            {
                Thread.Sleep(1000);
                Console.Clear();

                Console.WriteLine($"Finished placing your order.");
                Thread.Sleep(2000);
                Console.WriteLine("Checking out and calculating your order total..please wait..");
                Thread.Sleep(5000);

                Console.Clear();
            }
            else
            {
                Console.WriteLine("Have a nice day!");
            }
            if (Total > 0 && code != 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"Your outstanding total is {Total:C2}");
            }
            return Total;
        }
    }
}

