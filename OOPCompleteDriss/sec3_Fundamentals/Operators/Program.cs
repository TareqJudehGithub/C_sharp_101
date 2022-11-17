namespace Operators;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Operators\n");

        Console.WriteLine("Post Increment i++");

        // post-fix increment
        int i = 0;
        int j = 0;

        j = i++;
        Console.WriteLine($"J = {j}\n");
        // prefix increment
        j = ++i;

        Console.WriteLine($"J = {j}");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

    }
}
