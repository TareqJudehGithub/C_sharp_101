namespace MutliDimensionalArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-dimensional Arrays (2D Array)\n");

            // 2D array - declaration
            string[,] matrix;

            // 2d array - initialization
            int[,] array2D = new int[,]
            {
                {10, 40, 57},
                {100, 250, 155},
                {1006, 5019,  3574}
            };
            // access 2day array elements
            // access the first element in the 2nd group
            Console.WriteLine($"The 1st element in the 2nd element group: {array2D[1, 0]}");

            // // access the 3rd element in the 3rd group
            Console.WriteLine($"The 3rd element in the 3rd group: {array2D[2, 2]}\n");



            // 3D Array - declaration
            string[,,] studentScores = new string[,,]
            {
                {
                    {"Ali", "95" },
                },
                {
                    {"Tareq", "84" }
                }
            };

            // access StudentScores elements
            Console.WriteLine($"Name: {studentScores[0, 0, 0]}, Score: {studentScores[0, 0, 1]}");


            //  arrayName.Rank method - returns the array dimensional rank
            Console.WriteLine($"This array is rank: {array2D.Rank}");
            // $ This array is rank: 2

            Console.WriteLine($"This array is rank: {studentScores.Rank}");
            // $ This array is rank: 3


        }
    }
}