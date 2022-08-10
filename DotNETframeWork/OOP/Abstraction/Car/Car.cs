using System;

public class Car
{
    // fields
    private int id;
    private string model;
    private int year;
    private string color;
    private double price;

    public static int SeatNumbers;
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
        //id = value;
        this.id = value;
    }
    public void SetModel(string value)
    {
        this.model = value;
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

    public static void SetSeatNumbers(int value)
    {
        SeatNumbers = value;

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
    public static int GetSeatNumbers()
    {
        return SeatNumbers;
    }


    // methods
    public void TaxAmount(double price, double percentage = 0.16) // default parameter value.
    {
        double taxAmount = price * percentage;
        Console.Write($"Tax amount = {taxAmount:C0}");
    }

    // static methods
    public static void CarInfo()
    {

    }
}



