namespace Branches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If statements");
            int a = 15;
            int b = 25;

            if (a > b)
            {
                Console.WriteLine($"{a} is greater than {b}");
            }
            else
            {
                Console.WriteLine($"{b} is greater than {a}");
            }
            Console.WriteLine(" ");

            Console.Write("Weather today: ");
            string weather = "warm";
            bool isRaining = false;

            // Check what to wear 
            if ((weather == "warm") && (isRaining == false))
            {
                Console.WriteLine("It's OK to wear a t-shirt today! Enjoy the sum!");
            }
            else if ((weather == "cold") && (isRaining == false))
            {
                Console.WriteLine("Wear a jacket it's going to be cold today.");
            }
            else if ((weather == "cold") && (isRaining == true)) 
            {
                Console.WriteLine("Take an umbrella it's raining today!");
            }
            else
            {
                Console.WriteLine("Invalid entry or user values.");
            }

            // Loops
            Console.WriteLine("while loop");
            int num = 0;
            while (num < 10)
            {
                Console.WriteLine($"{num} is less  than 10");
                num++;
            }
            Console.WriteLine("End of while loop");

            // for loop
            Console.WriteLine("\nfor loop\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i} is less than 10");
            }
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($"The cell is ({row}, {column})");
                }
            }
            


        }

    }
}