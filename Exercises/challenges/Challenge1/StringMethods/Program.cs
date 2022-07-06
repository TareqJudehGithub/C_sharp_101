// See https://aka.ms/new-console-template for more information
Console.WriteLine("String Methods/n");

string name;
Console.Write("Enter your name: ");
name = Console.ReadLine();

Console.WriteLine(name.ToUpper().Trim());
Console.WriteLine(name.ToLower().Trim());
Console.WriteLine(name.Substring(4).Trim());

