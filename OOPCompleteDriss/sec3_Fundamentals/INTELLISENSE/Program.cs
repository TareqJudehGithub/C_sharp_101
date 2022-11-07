namespace INTELLISENSE;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Intellisense\n");

        string myString = "I love C#";

        bool isTrue = myString.StartsWith('I');
        Console.WriteLine(isTrue);
    }
}
