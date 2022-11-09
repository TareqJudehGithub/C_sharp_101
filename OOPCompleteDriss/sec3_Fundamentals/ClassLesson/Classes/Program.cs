namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes");

            // Instantiate new objects from classes
            var earth = new Planet(1);
            // OR
            Planet mars = new Planet(2);

            // Method calls
            earth.Name = "Earth";
            earth.Radius = 10000;
            Console.WriteLine("");

            earth.PrintInfo();
            Console.WriteLine("");

            int temp = earth.GetTemperature();
            Console.WriteLine($"Planet {earth.Name} Temp is: {temp}C");
            Console.WriteLine("");

            earth.AddSatellite("Moon");
            Console.WriteLine("");

            earth.PrintInfo();

        }
    }
}