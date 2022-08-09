using System;

public class Car
{
    // fields
    private int id;
    private string model;
    private int year;
    private string color;
    private double price;
    private readonly string dateOfPurchase;

    // constructor
    public Car()
    {
        Console.WriteLine("\nThis is the constructor\n");
        dateOfPurchase = DateTime.Now.ToShortDateString();
        Console.WriteLine("End of constructor\n");
    }

    // Setters
    public void SetId(int value)
    {
        id = value;
    }
    public void SetModel(string value)
    {
        model = value;
    }
    public void SetYear(int value)
    {
        year = value;
    }
    public void SetColor(string value)
    {
        color = value;
    }
    public void SetPrice(double value)
    {
        price = value;
    }

    // Getters
    public int GetId()
    {
        return id;
    }

    public string GetModel()
    {
        return model;
    }
    public int GetYear()
    {
        return year;
    }
    public string GetColor()
    {
        return color;
    }
    public double GetPrice()
    {
        return price;
    }
    public string GetDateOFPurchase()
    {
        return dateOfPurchase;
    }

    // methods
    public void TaxAmount(double price)
    {
        double taxAmount = price * 0.1D;
        Console.Write($"Tax amount = {taxAmount:C0}");
    }
}



