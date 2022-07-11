// See https://aka.ms/new-console-template for more information
namespace Methods
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Methods\n");

            string username = "John Smith\n";
            greetUser(username);

            int addResult = Add(5, 5);
            Console.WriteLine(addResult);

            int productResult = MultiPly(10, 10);
            Console.WriteLine(productResult);

            double divisionResult = Divide(25, 13);
            Console.WriteLine(divisionResult);
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
        /**
         * A method that calculate the sum of two arguments
         */

        {
            Console.Write($"The sum of {num1} + {num2} = ");
            return num1 + num2;
        }
        public static int MultiPly(int num1, int num2)
        /**
         * A method that calculate the product of two arguments
         */
        {
            Console.Write($"The product of {num1} * {num2} = ");
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            /**
             * A method that calculate the division result of two arguments
             */
            Console.Write($"{num1} / {num2} = ");
            return num1 / num2;
        }

    }
}
