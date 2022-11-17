namespace WhileLoop;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("While Loops\n");

        int counter = 0;
        while (counter <= 10)
        {
            counter++;
            if (counter % 3 == 0)
            {
                Console.WriteLine($"{counter} is a multiple of 3");
            }
            else
            {
                Console.WriteLine(counter);
            }
        }
    }
}
