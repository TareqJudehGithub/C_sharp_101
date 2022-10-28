namespace Abstarction
{
    public class ClassicCar : Car
    {
        public ClassicCar(string brand, string model, string color, int year)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;
        }
        public override void CarDetails(string brand, string model, string color, int year)
        {
            Brand = brand;
            Model = model;
            Color = color;
            Year = year;

            System.Console.WriteLine($"Brand: {Brand}\n" +
                $"Model: {Model}\n" +
                $"Color: {Color}\n" +
                $"Year: {Year}");
        }
        public override void CarInfo(double price, double insurance)
        {
            Price = price;
            Insurance = insurance;
            System.Console.WriteLine($"Car Price: {Price:C}\n" +
                $"Car Insurance Amount: {Insurance:C}");
        }
    }
}
