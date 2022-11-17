namespace Decimals;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Decimal type\n");
        decimal dividend = 1m;
        decimal divisor = 3m;

        decimal divisoinResult = dividend / divisor;
        Console.WriteLine($"{dividend} / {divisor} = {divisoinResult}");

        // Decimal methods
        decimal product;

        product = decimal.Add(dividend, divisor);
        decimal one = decimal.One;


    }
}
