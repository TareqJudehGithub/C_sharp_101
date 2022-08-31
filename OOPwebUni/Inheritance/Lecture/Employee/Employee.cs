public class Employee
{
    // fields
    private int _empID;
    private string _empName;
    protected private string _location;
    private int _salary;

    // constructors

    // parameter-less
    public Employee()
    {

    }
    // parameterized
    public Employee(int id, string name, string location)
    {
        EmpID = id;
        EmpName = name;
        Location = location;
    }

    // properties

    internal int EmpID
    {
        set
        {
            this._empID = value;
        }
        get
        {
            return this._empID;
        }
    }
    public string EmpName
    {
        set
        {
            this._empName = value;
        }
        get
        {
            return this._empName;
        }
    }
    public string Location
    {
        set
        {
            this._location = value;
        }
        get
        {
            return this._location;
        }
    }
    internal int Salary
    {
        get
        {
            return this._salary = 800;
        }
    }


    // Methods
    public void EmployeeDetails()
    {
        System.Console.WriteLine($"ID: {EmpID}\nName: {EmpName}\nLocation:{Location}\nSalary: {Salary}");
    }

    public virtual string GetHealthInsurance()
    {
        return "Health Insurance amount is: $" + 500;
    }
}

