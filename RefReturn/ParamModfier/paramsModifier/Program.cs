public class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        System.Console.WriteLine(subjects[0]);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.DisplaySubjects("Theory of Competition", "Computer Science", "Math");
    }
}

