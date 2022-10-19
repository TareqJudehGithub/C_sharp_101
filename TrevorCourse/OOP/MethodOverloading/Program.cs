using MethodOverloading;

namespace OOPintro
{
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            // Instantiate new object (instances) from Car class
            Car bmw = new Car();

            // Variables          
            DateTime dateNow = DateTime.Now;
            int year = dateNow.Year;

            Console.Write("Enter car brand: ");
            bmw.Brand = Console.ReadLine();

            Console.Write("Enter car model: ");
            bmw.Model = Console.ReadLine();

            Console.Write("Enter car manufacturing year: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            bmw.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Automatic gear: ");
            bmw.IsAutomatic = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Leather Seat: ");
            bmw.IsLeatherSeats = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("");

            bmw.CarSpec(year);
        }
    }
}