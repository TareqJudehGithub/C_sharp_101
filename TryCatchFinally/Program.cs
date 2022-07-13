using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try, Catch, and Finally\n");
            
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            try 
            {
                int convertInput = Int32.Parse(userInput);
                Console.WriteLine($"Your enter the number {convertInput}");
            }
            catch(FormatException) {
                Console.WriteLine("Check format data type and try again.");
            }
            finally 
            {
                Console.WriteLine("This line of code will be compiled either way.");
            }
            
            
        }
    }
}
