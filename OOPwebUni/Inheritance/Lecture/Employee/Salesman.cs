
public class Salesman : Employee
{
    // fields
    private string _region;


    // constructor
    public Salesman(int id, string name, string location, string region) : base(id: id, name: name, location: location)
    {
        Region = region;
    }
    // properties
    public string Region
    {
        set
        {
            this._region = value;
        }
        get
        {
            return this._region;
        }
    }
    public int Salary { get; set; } = 500;

    // methods

    // method hiding  - Here we r hiding the salary in the Employee class method named EmployeeDetails()
    public new void EmployeeDetails()
    {
        System.Console.WriteLine($"ID: {EmpID}\nName: {EmpName}\nLocation:{Location}\nRegion: {Region}\nSalary: {Salary}");
    }
    public long GetSalesOfTheCurrentMonth()
    {
        return 10000;
    }

    // method overriding - overriding method GetHealthInsurance()

    public override string GetHealthInsurance()
    {
        System.Console.WriteLine(base.GetHealthInsurance());
        return "Additional Health Insurance is :  $" + 250;

    }
}
