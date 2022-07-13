// See https://aka.ms/new-console-template for more information

Console.WriteLine("Exceptions\n");

Console.Write("Enter a number: ");
string? userInput = Console.ReadLine();

try
{
    Convert.ToInt32(userInput);
}
catch (FormatException)
{
    Console.WriteLine("Error In format. Please check format type.\n");

}
finally
{
    Console.WriteLine("End of code.");
}

Console.WriteLine($"You have entered the number {userInput}");






