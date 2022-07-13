namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators\n");

            int num1 = 5;
            int num2 = 3;
            int num3;

            bool isSunny = true;

            try
            {

                num3 = -num1;
                Console.WriteLine($"Num3 is {num3}");

                // ternary operator
                string whatToDo = isSunny ? "Wear a t-shirt and go out" : "Stay home and watch Netflix";
                Console.WriteLine(whatToDo);
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }
        }
    }
}