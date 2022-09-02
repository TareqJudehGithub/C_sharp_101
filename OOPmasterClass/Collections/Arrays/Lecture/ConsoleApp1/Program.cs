namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays\n");

            // Declare a new array
            int[] grades = new int[5];

            // initialize grades elements with values
            grades[0] = 92;
            grades[1] = 82;
            grades[2] = 87;
            grades[3] = 89;
            grades[4] = 77;

            // Access arrays elements
            Console.WriteLine($"Grade 1 = {grades[0]}");

            // update grades elements values
            Console.Write("Grade 1: ");
            grades[0] = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Grade 1 = {grades[0]}\n");

            int[] studentGrades = { 97, 82, 74, 91, 82 };

            // Return array length
            Console.WriteLine($"studentGrades array length is: {studentGrades.Length}");



        }
    }
}