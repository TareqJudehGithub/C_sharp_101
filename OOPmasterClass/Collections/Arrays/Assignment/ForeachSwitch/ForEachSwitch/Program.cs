namespace ForEachSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("foreach & switch\n");

            var userInputValue = 213.354F;

            Console.WriteLine(userInputValue.GetType());

            if (userInputValue is string)
            {
                Console.WriteLine($"You have entered a string value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is int)
            {
                Console.WriteLine($"You have entered an integer value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is bool)
            {
                Console.WriteLine($"You have entered a boolean value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is float)
            {
                Console.WriteLine($"You have entered a float value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is double)
            {
                Console.WriteLine($"You have entered a double value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is long)
            {
                Console.WriteLine($"You have entered a long value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else if (userInputValue is decimal)
            {
                Console.WriteLine($"You have entered a decimal value: {userInputValue}");
                Console.WriteLine($"{userInputValue.GetType()} it is!");
            }
            else
            {
                Console.WriteLine("Other data type entered.");
            }
        }
    }
}
