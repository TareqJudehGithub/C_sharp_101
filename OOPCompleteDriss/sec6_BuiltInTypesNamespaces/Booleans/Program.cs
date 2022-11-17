namespace Booleans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Booleans\n");

            bool condition = 8 > 15;
            string message = condition ? "The condition is true." : "The condition is false.";

            Console.WriteLine($"Condition: {message}");
            Console.WriteLine($"{nameof(message)}: {message}");

            Console.WriteLine("");
            // Negation operator !var

            bool answer = false;

            if (!answer)
            {
                Console.WriteLine($"{nameof(answer)} is {answer} False");
            }
            else
            {
                Console.WriteLine($"{nameof(answer)} is {answer} True");
            }

            string str1 = "TRUE";
            string str2 = "true";
            string str3 = "false";

            bool str1Parsed = bool.Parse(str1);
            bool str2Parsed = Boolean.Parse(str2);
            bool str3Parsed = bool.Parse(str3);

            bool comparingBools = str1Parsed == str2Parsed && str2Parsed == str3Parsed && str1Parsed == str3Parsed ? true : false;

            Console.WriteLine($"{nameof(comparingBools)}: {comparingBools}");
        }

    }
}