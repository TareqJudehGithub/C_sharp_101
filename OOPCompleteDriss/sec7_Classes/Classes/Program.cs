namespace Classes
{
    internal partial class Program
    {
        static void Main(string[] args)
        {

            // Instantiating 3 objects from Movie class
            Movie predator = new Movie();        // explicit
            var terminator = new Movie();       // implicit
            Movie starWars = new();               // Target-Type new expression

            string greetUser = "Hello World!";
            Console.Clear();
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            greetMe(user);

        }
        static void greetMe(string userName)
        {
            Console.WriteLine($"Hello, {userName}!");
        }
    }

}