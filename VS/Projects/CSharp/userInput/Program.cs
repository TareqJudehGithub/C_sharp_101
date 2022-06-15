// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Hi, what is your name? ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

// other data types inputs
Console.WriteLine("What is your age? ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Hi, {name}! You're {age} old today.");

