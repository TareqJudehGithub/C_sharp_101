namespace Construct
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate a n new object from Employee class
            Employee ali = new Employee(name: "ali", job: "Sales");
            Employee sarah = new Employee(name: "Sarah", job: "Marketing");

            // Object Initializer
            Employee ahmad = new Employee()
            {
                empName = "Ahmad"
            };

            System.Console.WriteLine(ali.GetEmpID());
            System.Console.WriteLine(ali.GetEmpName());
            System.Console.WriteLine(Employee.companyName);
            System.Console.WriteLine(ali.GetEmpJob());

            System.Console.WriteLine("");

            System.Console.WriteLine(sarah.GetEmpID());
            System.Console.WriteLine(Employee.companyName);
            System.Console.WriteLine(sarah.GetEmpName());
            System.Console.WriteLine(sarah.GetEmpJob());

            System.Console.WriteLine("");

            System.Console.WriteLine(ahmad.GetEmpID());
            System.Console.WriteLine(ahmad.GetEmpName());
        }
    }
}
