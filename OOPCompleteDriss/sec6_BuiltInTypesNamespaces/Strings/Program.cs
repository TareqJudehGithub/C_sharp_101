namespace Strings;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Strings");

        string greet = "Hello World!";

        string string1 = null;

        // StartsWith method
        Console.WriteLine($"{nameof(string1)} starts with an h? {greet.StartsWith('h')}");
        Console.WriteLine($"{nameof(string1)} starts with an H? {greet.StartsWith('H')}");

        // Substring
        string world = greet.Substring(6, greet.Length - 6);
        Console.WriteLine(world);

        // format
        string salute = "Hello, ";
        string userName;

        Console.Write("Enter username: ");
        userName = Console.ReadLine();

        string greetUser = string.Format("{0} {1}!", salute, userName);
        Console.WriteLine(greetUser);

        // StringBuilder
        Console.WriteLine($"int default value: {default(int)}");



    }
}
