namespace RepetitionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For Loop (Counter Controlled)
            Console.WriteLine("\nfor loop");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i} This is the for loop");
            }
            Console.WriteLine("End of for loop\n");



            // While Loop (Condition  Controlled - Pre check)
            Console.WriteLine("\nwhile loop");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number < 5)
            {
                Console.WriteLine($"{number} This is a while loop!");
                number++;
            }
            Console.WriteLine("End of while loop\n");



            // Do and While  Loop (Condition  Controlled - Post check)
            Console.WriteLine("\ndo while loop");
            Console.Write("Enter your lucky number: ");
            int luckyNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your lucky number is {luckyNumber}");
            while (luckyNumber < 5)
            {
                Console.WriteLine($"{luckyNumber} do-while loop");
                luckyNumber++;
            }
            Console.WriteLine("End of for loop\n");



            // Foreach  Loop
        }
    }
}