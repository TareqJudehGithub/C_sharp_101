namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods in C#\n");

            // instances
            MovieFactory movieFactory = new MovieFactory();
            CalculationHelper calculator = new CalculationHelper();

            Console.WriteLine($"5 squared = {calculator.Square(integer: default)}\n");
            Console.WriteLine($"5.5 squared = {calculator.Square(num: 5.5F)}\n");

            Console.Write("Enter a value: ");
            double doubleNum = Convert.ToDouble(Console.ReadLine());

            double cubedValue = CalculationHelper.Cubed(doubleNum);
            Console.WriteLine(cubedValue);


            var predator = movieFactory.CreateMovie(id: 1, title: "Predator", overview: "8/10"); // named arguments
            Console.WriteLine(predator);

            var defaultMovie = movieFactory.CreateMovie();
            Console.WriteLine(defaultMovie);


            Console.WriteLine("Parameters: by value");
            int number = 100;
            calculator.SquareByValue(number);
            Console.WriteLine(number);

            Console.WriteLine("\nParameters: by reference");
            calculator.SquareByRef(ref number);
            Console.WriteLine(number);
        }




    }
}