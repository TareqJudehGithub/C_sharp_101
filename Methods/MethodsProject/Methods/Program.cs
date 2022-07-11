// See https://aka.ms/new-console-template for more information
namespace Methods
{
    class Program 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Methods\n");
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            greetUser(username);

        }

        public static void greetUser(string user)
            /**
             * A method that greets the user
             * params: username input
             */
        {
            Console.WriteLine($"Hello, {user}!");
        }

    public static int Add(int num1, int num2)
        {
            Console.Write($"The sum of {num1} + {num2} = ")
            return num1 + num2;
        }
    }
}