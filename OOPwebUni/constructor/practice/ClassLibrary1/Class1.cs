public class Employee
{
    // fields
    public int empID;
    public string empName;
    public string empJob;

    // static fields
    public static string companyName;

    // constructor
    public Employee(int id, string name, string job)
    {
        this.empID = id;
        this.empName = name;
        this.empJob = job;
    }

    // static constructor
    static Employee()
    {
        companyName = "Test Company";
    }



    // Setters


    // Getters

    public int GetEmpID()
    {
        return empID;
    }
}