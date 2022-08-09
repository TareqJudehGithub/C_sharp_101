using System;
class OOPfields
// This class references to ClassLibrary1 class
{
    static void Main()
    {
        // create objects 
        Product product1 = new Product();
        Product product2 = new Product();
        Product product3 = new Product();

        // Initialize fields

        // object 1
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 120;
        product1.quantityInStock = 25;

        // object 2
        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 540;
        product2.quantityInStock = 36;

        // object 3
        product3.productID = 1003;
        product3.productName = "PC";
        product3.cost = 850;
        product3.quantityInStock = 19;

        // Get field values
        // object 1
        Console.WriteLine($"ID: {product1.productID}");
        Console.WriteLine($"Name: {product1.productName}");
        Console.WriteLine($"Cost: {product1.cost:C}");
        Console.WriteLine($"in Stock: {product1.quantityInStock:N}\n");
        Console.WriteLine($"Date of purchase: {product1.dateOfPurchase}");

        // object 2
        Console.WriteLine($"ID: {product2.productID}");
        Console.WriteLine($"Name: {product2.productName}");
        Console.WriteLine($"Cost: {product2.cost:C}");
        Console.WriteLine($"in Stock: {product2.quantityInStock:N}\n");

        // object 3
        Console.WriteLine($"ID: {product3.productID}");
        Console.WriteLine($"Name: {product3.productName}");
        Console.WriteLine($"Cost: {product3.cost:C}");
        Console.WriteLine($"in Stock: {product3.quantityInStock:N}\n");

    }
}

public class InternationalProduct : Product  // child class in another assembly
{

    public void method1()
    {
        int quantity = quantityInStock; // public field in another assembly.
        string productExpDate = expiryDate;  // protected internal in another assembly.
        productExpDate = "05-11-2023";

        string catProduct = CategoryName; // accessing const variable
    }
}