using System;

namespace MethodsOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTS
            const string developerName = "Tareq";

            Product product1 = new Product();
            Product product2 = new Product();
            Product product3 = new Product();

            // Initialize fields with values
            int prodID = product1.productID = 1001;
            string prodName = product1.productName = "Mobile";
            double prodCost = product1.cost = 250.75;
            int prodStock = product1.quantityInStock = 25;
            int quantity = Product.TotalNoProducts++;

            Console.WriteLine($"Developer: {developerName}");
            Console.WriteLine($"Product ID: {prodID}");
            Console.WriteLine($"Product Name: {prodName}");
            Console.WriteLine($"Product Cost: {prodCost}");
            Console.WriteLine($"Product Stock: {prodStock}");

            Console.WriteLine($"Quantity: {quantity}");

            // Calling methods
            product1.CalculateTax();



        }
    }
}
