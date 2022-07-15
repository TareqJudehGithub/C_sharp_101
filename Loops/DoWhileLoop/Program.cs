namespace DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while loop\n");

            int counter = 15;

            do
            {
                Console.WriteLine(counter);
                counter -= 5;
            }
            while (counter > 0);
            Console.WriteLine(counter);

        }
    }
}