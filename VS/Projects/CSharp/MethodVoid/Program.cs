namespace MethodVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods - Void\n");
            greet();
            Console.WriteLine($"Addition: {addition(10, 15)}" );
        }
        static void greet()
        {
            /**
             * A function that outputs Hello world!
             */ 
            Console.WriteLine("Hello, world!");
        }

        static int addition(int num1, int num2)
            /**
             * A method that calculates the sum of the 1st and 2nd arguments
             * parameters: int num1, int num2
             * returns: the sum of num1 and num2
             */
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}" );
            return num1 + num2;
        }
    }
}