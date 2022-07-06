namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types and Variables\n");

            // Declaring a variable
            int num1;

            // Assign a value to a variable (initializing a variable with a value)
            num1 = 13;
            Console.WriteLine(num1);

            int num2 = 23;

            int sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} + {num2} = {sum}\n");

            double d1 = 3.1545;
            double d2 = 5.11;
            double dDiv = d1 / d2;
            Console.WriteLine(dDiv);

            float f1 = 3.1545f;
            float f2 = 5.11f;
            float fDiv = f1 / f2;
            Console.WriteLine(fDiv);

            // strings

        }
    }
}