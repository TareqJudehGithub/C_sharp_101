namespace Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string firstString;
            firstString = "My first string!";

            Console.WriteLine($"{nameof(firstString)} = {firstString}\n");


            string methodGreet = Greet("one two three four five");
            Console.WriteLine(methodGreet);
        }

        static string Greet(string userInput)
        {
            string result = string.Empty;

            string[] strings = userInput.Split();
            string[] stringCapitalized = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                stringCapitalized[i] = Char.ToUpper(strings[i][0]) + strings[i].Substring(1);
                result = string.Join(" ", stringCapitalized);
            }
            return result;
        }
    }
}