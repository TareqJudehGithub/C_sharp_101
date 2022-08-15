class Student
{
    // fields
    public int grade = 2;

    // methods
    public void PrintGrade()
    {
        System.Console.WriteLine($"Grade: {grade}");
    }

    // method with ref return
    public ref int DoWork()
    {
        // return reference of grade field
        return ref grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // instantiating new objects of Student class
        Student student = new Student();

        // calling methods
        ref int work = ref student.DoWork();

    }
}