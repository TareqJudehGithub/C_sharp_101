namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for loops\n");

            countdown();
            Console.WriteLine("\n");
            oddEven();
        }

        static void countdown()
        {
            /* 
             * This method counts down from 10 to 0, and outputs "GO!" when the counter reaches zero.
             */
            for (int i = 10; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.WriteLine("GO!");
                    break;
                }
                Console.WriteLine(i);
            }
        }
        static void oddEven()
        {
            /*
             * This determines which is odd and which is even looping from 0 to 20.
             */

            for (int i = 0; i <= 20; i++)
            {
                string OddOrEven = i % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine($"{i} is an {OddOrEven} number.");
            }
        }
    }
}