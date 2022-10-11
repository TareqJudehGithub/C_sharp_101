class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Arrays in C#\n");

        // Declare Fixed Size Array
        int[] studentScores = new int[5];

        // Declare and initialize a new Array with values.
        string[] friendsList = new string[] { "Ali", "Muhammad", "Sarah", "Baker", "John" };

        // Add new elements/items to an Array
        studentScores[0] = 93;
        studentScores[1] = 82;
        studentScores[2] = 87;
        studentScores[3] = 79;
        studentScores[4] = 92;

        // Print values in a fixed Array
        foreach (int score in studentScores) Console.WriteLine(score);
        Console.WriteLine("");

        for (int i = 0; i < studentScores.Length; i++) Console.WriteLine(studentScores[i]);
        Console.WriteLine("");

        Console.WriteLine($"The average score = {studentMarks()}");

    }

    // Write a program that allows a teacher to enter a student's marks, and then calculating the average.

    static double studentMarks()
    /* This programs allows the user to enter 5 numbers, calculating the total and the average of those numbers.*/
    {
        double studentMark = 0;
        double sum = 0;
        double average = 0;



        // 1. Declare a new Array 
        double[] marks = new double[5];

        while (average == 0)
        {

            try
            {
                // Teacher marks entry, adding each mark to sum calculating total marks
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.Write("Enter a mark: ");
                    studentMark = Convert.ToDouble(Console.ReadLine());
                    if (typeof(double).IsAssignableFrom(studentMark.GetType()))
                    {
                        sum += studentMark;
                    }
                    //else
                    //{
                    //    Console.WriteLine("Only numbers are allowed.");
                    //    Thread.Sleep(1000);

                    //    Console.Write("Enter a mark: ");
                    //    studentMark = Convert.ToDouble(Console.ReadLine());
                    //    sum += studentMark;
                    //}
                }

                // Calculate average
                average = sum / marks.Length;

            }
            catch (FormatException err)
            {
                Console.WriteLine($"Invalid format! Please enter a number.\n{err.Message}");
            }
            finally
            {
                Console.WriteLine("End or program\n");
            }
        }
        return Math.Round(average, 2);
    }
}