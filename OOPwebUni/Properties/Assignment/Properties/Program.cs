namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new object from Employee class
            Employee waleed = new Employee(id: 101, name: "Waleed", job: "Clerk", salary: 1000, tax: 75.75);


            // Calling methods
            waleed.NativePlace = "Aqaba";
            waleed.EmployeeInfo();
            System.Console.WriteLine("$" + waleed.CalculateNetSalary());
        }
    }
}
