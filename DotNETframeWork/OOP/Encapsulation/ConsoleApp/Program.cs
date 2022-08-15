public class Program
{
    static void Main(string[] args)
    {
        // Instantiate new object from Car class
        Car gmc = new Car();

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
        System.Console.WriteLine($"Price: {gmc.GetPrice()}");
        System.Console.WriteLine($"Date of Purchase: {gmc.GetDateOFPurchase()}");

        // methods:
        double tax = 0.1;
        gmc.TaxAmount(gmc.GetPrice(), in tax);
        System.Console.WriteLine("\n");

        string color = "Green";
        gmc.CarDetails(model: gmc.GetModel(), year: gmc.GetYear(), color: ref color);

        System.Console.WriteLine("\n");
    }

}

