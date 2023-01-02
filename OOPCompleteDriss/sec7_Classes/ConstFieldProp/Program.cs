namespace ConstFieldProp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Demo: const, fields, and properties\n");

        //    // new obj
        //    WeightConverter converter = new WeightConverter();

        //    Console.Write("Please enter mass amount/kgs: ");
        //    var massInput = Console.ReadLine();

        //    if (float.TryParse(massInput, out var mass))
        //    {
        //        Console.WriteLine($"Your weight equals: {WeightConverter.Convert(mass)} newtons.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid entry.");
        //    }
        //}
        static void Main(string[] args)
        {
            MovieService movies = new MovieService();

            var moviesList = movies.GetMovies();

            foreach (var movie in moviesList)
            {
                Console.WriteLine($"Movies description:\n{movie.Description}\n");
            }
        }
    }
}