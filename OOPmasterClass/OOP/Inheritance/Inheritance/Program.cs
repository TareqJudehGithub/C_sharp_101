namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance\n");

            // Instantiate new objects
            Radio walkman = new Radio(isOn: false, brand: "Sony T180i");
            TV samsung = new TV(isOn: true, brand: "Samsung QLED 2022");

            // Methods
            Console.WriteLine("Radio: Radio method");
            walkman.ListenToRadio();
            Console.WriteLine("");

            Console.WriteLine("Radio: base class method");
            walkman.StartDevice();
            Console.WriteLine("");

            Console.WriteLine("TV: TV method");
            samsung.WatchTV();

        }
    }
}