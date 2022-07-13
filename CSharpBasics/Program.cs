
public class Program
{
    public static void Main()
    {
        //Console.Write("Enter a number: ");

        Console.Write("Enter the numerator value: ");
        int numerator = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the denominator value: ");
        int denominator = Convert.ToInt32(Console.ReadLine());
        try
        {
            //int userInput = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You have entered the number {userInput}");

            //Console.WriteLine(numerator / denominator);
            decimal divResult = (decimal)numerator / (decimal)denominator;
            Console.WriteLine($"{numerator} / {denominator} = {divResult}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division by zero error. Denominator cannot be zero.");
        }
        catch (FormatException) // Wrong format type`
        {
            Console.WriteLine("\nError In format. Please check format type.");
        }
        catch (OverflowException) // Value exceeds limit
        {
            Console.WriteLine($"Your number is too large.");
        }
    }
}


