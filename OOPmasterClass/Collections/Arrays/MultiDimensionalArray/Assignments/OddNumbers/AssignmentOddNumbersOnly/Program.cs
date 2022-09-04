namespace AssignmentOddNumbersOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("");
            OddNumbers(numbers);
        }

        // methods
        static void OddNumbers(int[,] Array)
        {
            /*
             This method takes a 2d array as a parameter, iterates into every single element number, and prints out Odd ones.
             */
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] % 2 != 0) Console.WriteLine($"Odd number:  {Array[i, j]}");
                    else Console.WriteLine($"Even number: {Array[i, j]}");
                }
            }
        }
    }
}