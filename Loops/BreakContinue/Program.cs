namespace BreakContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Break - Continue\n");

            //for (int counter = 0; counter < 10; counter++)
            //{
            //Console.WriteLine(counter);
            //if (counter == 3)
            //{
            //    Console.WriteLine("Stopping the program!\n");
            //    break;
            //}

            //if (counter % 2 == 0)
            //{
            //    Console.WriteLine($"{counter} is an odd number.");
            //    //continue;
            //}
            //}
            int i = -10;

            while (i < 11)
            {
                // TODO
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;

            }
            //Console.WriteLine(i);            //Console.WriteLine(i);
        }
    }
}
