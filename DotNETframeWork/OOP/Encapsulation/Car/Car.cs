using System;
public class Car
{
    // fields
    public int id;
    public string model;
    public int year;
    public string color;
    public double price;
    public readonly string dateOfPurchase;

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
    public void TaxAmount(double price, in double tax)
    {

        double taxAmount = price * tax;
        Console.Write($"Tax amount = {taxAmount:C0}");
    }
    public void CarDetails(string model, int year, ref string color)  // ref keyword for arguments
    {
        color = "Red";
        Console.WriteLine($"Model: {model}\nYear: {year}\nColor: {color}");
    }
}


