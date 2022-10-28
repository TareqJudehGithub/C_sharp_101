namespace Abstarction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new objects
            ClassicCar jaguarE = new ClassicCar(brand: "Jaguar", model: "E-Type", color: "Silver", year: 1961);
            SportCar dodgeViber = new SportCar(brand: "Dodge", model: "Viber", color: "Red", year: 2022);

            // Methods call
            System.Console.WriteLine("\nCar Details:");
            jaguarE.CarDetails(brand: "Jaguar", model: "E-Type", color: "Silver", year: 1961);
            dodgeViber.CarDetails(brand: "Dodge", model: "Viber", color: "Red", year: 2022);

            System.Console.WriteLine("\nCar Info:");
            jaguarE.CarInfo(price: 45000.99, insurance: 15000.99);
            dodgeViber.CarInfo(price: 60000.99, insurance: 2000.55);
        }
    }
}
