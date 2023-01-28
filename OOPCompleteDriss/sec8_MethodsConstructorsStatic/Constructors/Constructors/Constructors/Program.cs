namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructors!\n");

            // Instances

            var actorsList = new List<Actor>
            {
                new Actor(firstName: "John", lastName: "Smith"),
               new Actor(firstName: "Sarah", lastName: "Adams"),
        };

            Movie movie1 = new Movie(title: "Titanic", overview: "9/10", actors: actorsList);
            Console.WriteLine(movie1.Actors.Count());

            Console.WriteLine("");

            Movie movie2 = new Movie(title: "Predator", overview: "8.5/10", actors: actorsList);
            Console.WriteLine(movie2.ToString());

        }
    }
}