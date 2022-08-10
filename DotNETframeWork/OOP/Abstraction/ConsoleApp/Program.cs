public class Program
{
    static void Main(string[] args)
    {
        // Instantiate new object from Car class
        Car gmc = new Car();
        Car.SetSeatNumbers(Car.GetSeatNumbers() + 5);

        // Initialize fields with values

        gmc.SetId(123456);
        gmc.SetModel("GMC Envoy CLS");
        gmc.SetYear(2006);
        gmc.SetColor("Charcoal");
        gmc.SetPrice(21000);

        // get values from fields
        System.Console.WriteLine($"ID: {gmc.GetId()}");
        System.Console.WriteLine($"Model: {gmc.GetModel()}");
        System.Console.WriteLine($"Year: {gmc.GetYear()}");
        System.Console.WriteLine($"Color: {gmc.GetColor()}");
        System.Console.WriteLine($"Number of Seats: {Car.GetSeatNumbers()}");
        System.Console.WriteLine($"Price: {gmc.GetPrice()}");

        // methods:
        gmc.TaxAmount(price: gmc.GetPrice(), percentage: 0.1);

        System.Console.WriteLine("");
    }
}

