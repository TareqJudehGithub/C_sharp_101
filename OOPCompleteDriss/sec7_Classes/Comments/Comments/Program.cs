namespace Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Comments in C#\n");

            // XML documentation comment
            // We can use XML docs at class level, and also at methods level. 

            Class1 calculator = new Class1();

            double addition = calculator.Sum(10, 5);
            Console.WriteLine($"The sum = {addition}");

        }
    }
}