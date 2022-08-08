public class Program
{

    static void Main()
    {
        // objects
        Employee employee1 = new Employee();

        string orgName = Employee.organizationName;
        string dept = employee1.departmentName;

        int ID = employee1.empID;
        ID = 1001;

        string name = employee1.empName;
        name = "John Smith";

        double salaryPerHour = employee1.salaryPerHour;
        salaryPerHour = 90.5D;

        int workingHours = employee1.noOfWorkingHours;
        workingHours = 48;

        // new employees
        System.Console.WriteLine($"ID: {ID}");
        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine($"Salary/Hour: {salaryPerHour:C}");
        System.Console.WriteLine($"Working Hours: {workingHours}");
        System.Console.WriteLine($"Department: {dept}");
        System.Console.WriteLine($"Organization name: {orgName}");

    }
}

