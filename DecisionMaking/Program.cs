// See https://aka.ms/new-console-template for more information

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if else statement\n");

            try
            {
                Console.Write("Enter today's temperature: ");
                int temperature = Convert.ToInt32(Console.ReadLine());


                if (temperature < 10)
                {
                    Console.WriteLine("Take the coat");
                }
                else if (temperature == 10)
                {
                    Console.WriteLine($"It's 10 degrees out there!");
                }
                else
                {
                    Console.WriteLine($"The weather is nice!");
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message); ;
            }
        }
    }
}

