namespace ExerciseArrayStudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Marks entry\n");
            Console.WriteLine("The average score is: " + studentAvgMarks());
        }
        static double studentAvgMarks()
        {
            /*
             * This method displays students marks entered by the user, and calculates
             * the average of these total marks.
             */

            int sum = 0;
            int[] studentMarks = new int[5];



            for (int i = 0; i < studentMarks.Length; i++)
            {
                Console.Write("Enter mark: ");
                studentMarks[i] = Convert.ToInt32(Console.ReadLine());
                sum += studentMarks[i];
            }

            Console.WriteLine(studentMarks);
            Console.Write("student marks: ");
            foreach (int mark in studentMarks)
            {
                Console.Write(mark + ", ");
            }
            Console.WriteLine($"Score total = " + sum + "\n");

            double avgMarks = (double)sum / studentMarks.Length;
            return avgMarks;
        }
    }
}