namespace IfStatement;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("If Statements\n");

        Random random = new Random();
        int randomNum = random.Next(1, 10);

        if (randomNum % 2 == 0)
        {
            Console.WriteLine($"{randomNum} is an even number.");
        }
        else
        {
            Console.WriteLine($"{randomNum} is an odd number.");
        }

    }
}
