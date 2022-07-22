// See https://aka.ms/new-console-template for more information



namespace Dotnet6NewFeatures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a program that swaps two variable values ");

            int a = 100;
            int b = 200;
            Console.WriteLine($"a = {a}, b = {b}");
            int c = a;
            a = b;
            b = c;

            Console.WriteLine($"a = {a}, b = {b}");

        }
    }

}
