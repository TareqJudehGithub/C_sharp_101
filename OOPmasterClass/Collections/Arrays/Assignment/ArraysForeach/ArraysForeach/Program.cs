namespace ArraysForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment - Arrays & foreach\n");

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            Console.WriteLine("");
            GetEven(array);

        }

        public static void GetOdd(int[] Array)
        {
            // TODO 
            Console.WriteLine("Odd numbers:");
            foreach (int num in Array)
            {
                if (num % 2 != 0) Console.WriteLine(num);
            }

        }

        public static void GetEven(int[] Array)
        {
            // TODO
            Console.WriteLine("Even numbers:");
            foreach (int num in Array)
            {
                if (num % 2 == 0) Console.WriteLine(num);
            }
        }

    }
}