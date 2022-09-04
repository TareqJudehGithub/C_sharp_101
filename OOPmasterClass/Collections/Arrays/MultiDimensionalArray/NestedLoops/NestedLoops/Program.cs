namespace NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nested loops in Dimensional Arrays\n");

            int[,] matrix =
              {
                    {1, 2, 3 },
                    {4, 5, 6 },
                    {7, 8, 9 }
              };

            // call methods

            // NestedLoop(matrix);
            DiagonalIteration(matrix);
        }


        // methods

        static void NestedLoop(int[,] Array)
        {
            Console.WriteLine("Iterate using for loop:");
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.WriteLine(Array[i, j]);
                }
            }
        }

        static void DiagonalIteration(int[,] Array)
        {
            //for (int i = 0; i < Array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Array.GetLength(0); j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.WriteLine(Array[i, j]);
            //        }
            //    }
            //}

            // shorter solution
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                // return 1 5 9
                if (Array[i, i] == Array[i, i]) Console.WriteLine(Array[i, i]);

                // or it could even still work without the if/else
                // Console.WriteLine(Array[i, i]);

            }
            Console.WriteLine("");
            // reverse
            for (int i = 0, j = 2; i < Array.GetLength(0); i++, j--) Console.WriteLine(Array[i, j]);

        }

    }
}
