namespace LocalFunctions
{
    internal class Student
    {
        internal void DisplayMarks(int mark1, int mark2, int mark3)
        {
            double avgScore = getAverageScore();
            System.Console.WriteLine($"Score = {avgScore:N2}");

            // Local function to calculate average score
            double getAverageScore()
            {
                double average = (double)(mark1 + mark2 + mark3) / 3;
                return average;
            }
        }

        internal void CalculateAvg(params int[] grades)
        {

            double avgScore()
            {
                double sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                double avgGrades = (double)sum / grades.Length;
                return avgGrades;
            }

            double avgMyGrades = avgScore();
            System.Console.WriteLine($"My average score = {avgMyGrades:N2}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.DisplayMarks(75, 95, 83);
            student.CalculateAvg(75, 95, 83, 79, 80);


        }
    }
}
