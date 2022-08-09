using System;

public class Product
{
    // fields

    public int productID;
    public string productName;
    public double cost;
    public int quantityInStock;

    public static int TotalNoProducts;
    public const string CategoryName = "Electronics";
    public readonly string dateOfPurchase;

    public double tax;


    // constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }

    // methods
    public void CalculateTax()
    {
        //double localVarTax;
        if (cost < 200)
        {
            tax = 0.1;
            Console.Write($"Tax amount {tax:P} for product cost {cost:C} = {cost * tax:C}");
            //localVarTax = 0.1;
            // Console.Write($"Tax amount {localVarTax:P} for product cost {cost:C} = {cost * tax:C}");
        }
        else
        {
            tax = 0.125;
            Console.Write($"Tax amount {tax:P} for product cost {cost:C} = {cost * tax:C}");
            //localVarTax = 0.125;
            //Console.Write($"Tax amount {localVarTax:P} for product cost {cost:C} = {cost * tax:C}");

        }
        Console.WriteLine($"\nTax = {tax:P2}");
    }

}