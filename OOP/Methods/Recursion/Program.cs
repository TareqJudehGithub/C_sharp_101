namespace Recursion
{

    internal class Factorial
    {
        public double FactorialCalc(int num)
        {
            if (num == 0) return 1;
            else
            {
                return num * FactorialCalc(num - 1);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            System.Console.WriteLine($"The factorial of 5 = {factorial.FactorialCalc(5)}");
        }
    }
}
