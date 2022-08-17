namespace Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a n new object from Employee class
            Employee ali = new Employee(id: 1001, name: "ali", job: "Sales");
            Employee sarah = new Employee(id: 1002, name: "Sarah", job: "Marketing");

            System.Console.WriteLine(ali.GetEmpID());
            System.Console.WriteLine(ali.empName);
            System.Console.WriteLine(Employee.companyName);
            System.Console.WriteLine(ali.empJob);

            System.Console.WriteLine("");

            System.Console.WriteLine(sarah.GetEmpID());
            System.Console.WriteLine(Employee.companyName);
            System.Console.WriteLine(sarah.empName);
            System.Console.WriteLine(sarah.empJob);
        }
    }
}
