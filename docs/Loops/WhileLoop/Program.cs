namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while loop");
            /* 
             Bus challenge:
                Keep looping as long as the user inputs an empty string.
             */

            int counter = 0;

            Console.Write("Please press Enter to count students: ");
            string userInput = string.Empty;

            while (userInput.Equals(string.Empty))
            {
                Console.WriteLine($"{counter} students have entered the bus.\n");
                Console.WriteLine("Hit enter again: ");
                userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Total students inside the bus are {counter}\nPress any key to close the program.");

        }

    }
}