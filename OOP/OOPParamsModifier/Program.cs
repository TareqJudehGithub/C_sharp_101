
class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        // System.Console.WriteLine(subjects[0]);
        foreach (string subjcet in subjects)
        {
            System.Console.WriteLine(subjcet);
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        // instantiating new objects of Student class
        Student student = new Student();


        // methods
        student.DisplaySubjects("Math", "Science", "Physics", "Biology");
    }
}