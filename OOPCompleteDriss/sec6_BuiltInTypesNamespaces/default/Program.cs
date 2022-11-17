class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The default value\n");

        int age = 47;
        Console.WriteLine($"The default value for {nameof(age)} is {default(int)}");

        string greet = "Hello World";
        Console.WriteLine($"The default value of {nameof(greet)} is {default(String)}");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine($"The default value of {nameof(numbers)} is {default(List<int>)}");

        // default literal
        int number = default;
        string day = default;

        Console.WriteLine($"{nameof(number)} is {number}");
        Console.WriteLine($"{nameof(day)} is {day}");

    }
}
