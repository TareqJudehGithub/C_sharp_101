namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new objects
            Employee scott = new Employee(id: 101, name: "Scott", location: "Amman");
            Employee noor = new Employee(id: 102, name: "Nour Abu Zaid", location: "Al - Rawabi");
            Manager bob = new Manager(id: 103, name: "Bob", location: "New York", deparment: "HR");
            Salesman ali = new Salesman(id: 104, name: "Ali", location: "Amman", region: "West");
            // Calling methods
            // Employees
            System.Console.WriteLine("Parent object class");
            scott.EmployeeDetails();
            noor.EmployeeDetails();
            System.Console.WriteLine(noor.GetHealthInsurance());

            System.Console.WriteLine("");

            // Managers
            System.Console.WriteLine("Child object class");
            bob.ManagerDetails();
            System.Console.WriteLine($"Sales of the year = {bob.GetTotalSalesOfTheYear()}");
            System.Console.WriteLine($"Department: {bob.GetDeparmentAndLocation()}");
            System.Console.WriteLine(bob.GetHealthInsurance());

            System.Console.WriteLine("");

            // Salesmen
            ali.EmployeeDetails();
            System.Console.WriteLine("");
            System.Console.WriteLine(ali.GetHealthInsurance());
        }
    }
}
