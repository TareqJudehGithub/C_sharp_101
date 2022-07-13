namespace MethodVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods - Void\n");

            greet();

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(addition(num1, num2));
            Console.WriteLine($"\nThe max value is {largestNumber(num1, num2, num3)}");
        }

        // Methods
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

            Console.Write($"The sum of {num1} + {num2} = ");
            return num1 + num2;
        }
        /**
         * A method that returns the largest integer number
         * Arguments: int num1, int num2, int num3
         * return: largest integer
         */
        static int largestNumber(int num1, int num2, int num3)
        {
            int maxValue = 0;
            if (maxValue < num1)
            {
                maxValue = num1;
            }
            if (maxValue < num2)
            {
                maxValue = num2;
            }
            if (maxValue < num3)
            {
                maxValue = num3;
            }
            return maxValue;
        }
    }
}
