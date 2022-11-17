namespace ForLoop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("For Loop\n");

        for (int i = 0; i <= 10; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine($"{i} is a multiple of 3.");
            }
            else
            {
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");

                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
                Console.WriteLine($"Counter = {i}");
            }
        }
    }
}
