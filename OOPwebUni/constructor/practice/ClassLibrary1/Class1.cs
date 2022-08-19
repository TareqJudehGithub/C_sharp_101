public class Employee
{
    // fields
    public int empID;
    public string empName;
    public string empJob;

    // static fields
    public static string companyName;
    private static int serialNo = 1;

    // constructors
    public Employee(string name, string job)
    {
        this.empID = serialNo;
        this.empName = name;
        this.empJob = job;

        serialNo++;
    }
    public Employee()
    {
        this.empID = serialNo;
        serialNo++;
    }

    // static constructor
    static Employee()
    {
        companyName = "Test Company";
    }


    // Setters
    public void SetEmpID(int value)
    {
        empID = value;
    }
    public void SetEmpName(string value)
    {
        empName = value;
    }
    public void SetEmpJob(string value)
    {
        empJob = value;
    }


    // Getters
    public int GetEmpID()
    {
        return empID;
    }
    public string GetEmpName()
    {
        return empName;
    }
    public string GetEmpJob()
    {
        return empJob;
    }

}