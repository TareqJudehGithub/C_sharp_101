namespace Inheritance
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance\n");

            Console.Write("Enter Length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            var cube = new Cube(width: width, height: height, length: length);
            var triangle = new Triangle(length: length, height: height);
            var triangleHypo = new Triangle(hypo: 25.5);
            var rectangle = new Rectangle(length: length, width: width);

            // Shapes Area:
            Console.WriteLine($"Cube volume: {cube.getArea()}");
            Console.WriteLine($"Triangle area: {triangle.GetArea()}");
            Console.WriteLine($"Rectangle area: {rectangle.getArea()}");

        }
    }
}