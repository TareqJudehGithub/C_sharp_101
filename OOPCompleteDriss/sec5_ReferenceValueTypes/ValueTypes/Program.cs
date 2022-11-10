namespace ValueTypes;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Value Types\n");
        int i = 0;
        int j = i;
        Console.WriteLine($"Before, {nameof(i)}: {i}, {nameof(j)}: {j}");
        i = 1;
        Console.WriteLine($"After, {nameof(i)}: {i}, {nameof(j)}: {j}");
    }
}
