Console.WriteLine("Exception Handling\n");
decimal num1 = 0;
decimal num2 = 0;
decimal divResult = 0;
try
{
    Console.Write("Enter the first number: ");
    num1 = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Enter the second number: ");
    num2 = Convert.ToDecimal(Console.ReadLine());
    divResult = num1 / num2;
    Console.WriteLine(divResult);
}
catch (FormatException formatError)
{
    Console.WriteLine($"Invalid format type:\n{formatError.Message}");
}
catch (DivideByZeroException divError)
{
    Console.WriteLine($"Division by zero value error:\n{divError.Message}");
}
finally
{
    Console.WriteLine("End of the program");
}



