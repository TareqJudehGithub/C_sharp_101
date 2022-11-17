namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do-While Loop\n");


            int counter = 0;
            do
            {
                counter++;
                if (counter % 3 == 0)
                {
                    Console.WriteLine($"{counter} is a multiple of 3!");
                }

                else
                {
                    Console.WriteLine($"Counter = {counter}");
                }
            }
            while (counter <= 10);
        }

    }
}