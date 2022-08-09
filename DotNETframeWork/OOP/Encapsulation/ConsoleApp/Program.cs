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

        //int gmcID = gmc.SetId(1541);
        //string gmcModel = gmc.SetModel("GMC Envoy CLS");
        //int gmcYear = gmc.SetYear(2006);
        //string gmcColor = gmc.SetColor("Charcoal");
        //double gmcPrice = gmc.SetPrice(21000);

        // get values from fields
        System.Console.WriteLine($"ID: {gmc.GetId()}");
        System.Console.WriteLine($"Model: {gmc.GetModel()}");
        System.Console.WriteLine($"Year: {gmc.GetYear()}");
        System.Console.WriteLine($"Color: {gmc.GetColor()}");
        System.Console.WriteLine($"Price: {gmc.GetPrice()}");

        // methods:
        gmc.TaxAmount(gmc.GetPrice());

        System.Console.WriteLine("");
    }

}

