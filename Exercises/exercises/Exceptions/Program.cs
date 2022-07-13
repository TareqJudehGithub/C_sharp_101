
Console.WriteLine("Divide by Zero exercise\n");

Console.Write("Enter the numerator value: ");
string? numerator = Console.ReadLine();

Console.Write("Enter the denominator value: ");
string? denominator = Console.ReadLine();
decimal divResult = 0M;

try 
{	        
	decimal numeratorDec = Convert.ToDecimal(numerator);
	decimal denominatorDec = Convert.ToDecimal(denominator);
	divResult = numeratorDec / denominatorDec;
}
catch(DivideByZeroException)
{
	Console.WriteLine("\nDenominator cannot be zero value\n");
}
finally
{
	Console.WriteLine("End of code\n");
}

if (divResult > 0)
{
Console.WriteLine($"{numerator} / {denominator} = {divResult}");
}