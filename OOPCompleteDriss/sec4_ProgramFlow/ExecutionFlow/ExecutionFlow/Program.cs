namespace ExecutionFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution Flow\n");

            Console.WriteLine("Statement 1");
            Console.WriteLine("Statement 2");

            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            Console.WriteLine($"Random number = {randomNumber}");

            if (randomNumber % 2 == 0)
            {
                Console.WriteLine("Statement 1");
                Console.WriteLine("Statement 2");
            }
            else
            {
                Console.WriteLine("Statement 3");
                Console.WriteLine("Statement 4");
            }
            for (int i = 0; i < 10; i++)
            {
                // If i is a multiple if 3
                if (i % 3 == 0)
                {
                    // Skip i
                    continue;
                }

                Console.WriteLine($"For statement {i}");
            }
        }
    }
}