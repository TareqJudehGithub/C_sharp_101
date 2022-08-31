
public sealed class Manager : Employee   // sealed class
{
    // fields
    private string _departmentName;
    // private int _salary;

    // properties
    internal string DepartmentName
    {
        set
        {
            this._departmentName = value;
        }
        get
        {
            return this._departmentName;
        }
    }
    internal int Salary { get; set; } = 1500;
    //{ THIS WORKS TOO LIKE IN Employee class.
    //    get { return this._salary = 1500; }
    //}

    // constructor
    public Manager(int id, string name, string location, string deparment) : base(id: id, name: name, location: location)
    {
        //EmpID = id;
        //EmpName = name;
        //Location = location;
        this._departmentName = deparment;
    }

    // methods
    public void ManagerDetails()
    {
        System.Console.WriteLine($"ID: {EmpID}\nName: {EmpName}\nLocation:{Location}\nDept: {DepartmentName}\nSalary: {Salary}");
    }
    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }
    public string GetDeparmentAndLocation()
    {
        return DepartmentName + " - " + base.Location;
    }

    // method hiding
    public new string GetHealthInsurance()
    {
        return "Health Insurance amount is: " + 1000;
    }
}

// The below code will return error
//public class BranchManager : Manager
//{

//}

