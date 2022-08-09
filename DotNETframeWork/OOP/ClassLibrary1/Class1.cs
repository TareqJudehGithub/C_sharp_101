using System;
public class Product
{
    // fields
    private int productID;
    protected string productName;
    private protected double cost;
    internal string productDescription;
    protected internal string expiryDate = "05-12-2024";
    public int quantityInStock;

    const string developerName = "Tareq"; // local constant
    public const string CategoryName = "Electronics";  // constant
    public readonly string dateOfPurchase;

    // constructor
    public Product()
    {
        dateOfPurchase = DateTime.Now.ToShortDateString();
    }
}

public class DomesticProduct : Product      // child class
{

    public void Method1()
    {
        string productA = productName;
        double productCost = cost;
        string description = productDescription;
        string expDate = expiryDate;
        int quantity = quantityInStock;

    }
}

public class OtherClass
{
    public void method2()
    {
        Product seperateClass = new Product();
        int stock = seperateClass.quantityInStock;
        string otherDescription = seperateClass.productDescription;
        string otherExpDate = seperateClass.expiryDate;
        int quantities = seperateClass.quantityInStock;

        string catName = Product.CategoryName;  // accessing a cons variable from outside the class.

    }
}

