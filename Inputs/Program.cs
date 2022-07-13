// See https://aka.ms/new-console-template for more information

namespace Inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inputs\n");

            Console.Write("Enter your name: ");

            string? userInput = Console.ReadLine();
            Console.WriteLine($"Hello, {userInput}");

            // Prompt the user to enter two integers
            Console.Write("Enter the first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The sum of {firstNum} + {secondNum} = {Addition(firstNum, secondNum)}");
        }
        static int Addition(int num1, int num2)
        /*
         * A method that find the sum of two integer arguments
         * params: int num1, int num2
         * return: num1 + num2
         */
        {
            return num1 + num2;
        }
    }
}