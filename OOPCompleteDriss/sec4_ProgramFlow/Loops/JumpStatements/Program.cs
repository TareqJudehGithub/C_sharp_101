namespace JumpStatements;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jump Statements\n");

        Random random = new Random();
        string todayIs = new string[7] { "Mon", "Tues", "Wed", "Thur", "Fri", "Sat", "Sun" }[random.Next(1, 8)];
        Console.WriteLine($"Today is {todayIs}");
    }
}
