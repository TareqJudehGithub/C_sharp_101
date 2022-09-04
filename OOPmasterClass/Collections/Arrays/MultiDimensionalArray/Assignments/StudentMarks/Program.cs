namespace StudentMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi-Dimensional Arrays Assignment\n");

            string[,] grades =
            {
                {"Science", "95" },
                {"Math", "88" },
                {"ICT", "98" },
                {"Chemistry", "89" }
            };

            //Console.WriteLine(grades[1, 1]);
            StudentMarks(grades);

        }

        // method
        static void StudentMarks(string[,] Array)
        {
            /*
             This method calculates average score of students marks.
             */

            double sum = 0;
            double average;
            double[] marks = new double[4];

            foreach (string item in Array)
            {
                if (Char.IsDigit(item[0]))  // check if the first char in the string in numeric
                {
                    double mark = Convert.ToInt32(item);
                    sum += mark;

                    for (int i = 0; i < marks.Length; i++)
                    {
                        marks[i] = mark;
                    }
                }
            }
            average = sum / marks.Length;
            Console.WriteLine($"The average = {average}");
        }
    }
}

