namespace OOPintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP Introduction\n");
            /* 
                - OOP allows us to create our own data type
                - A class is like blueprints of objects created from that class.
             */

            // Write a program that get users information

            // 1. Instantiate a new object/instance from class Person
            Person noor = new Person();
            Person mike = new Person();

            string firstName = noor.FirstName;
            string lastName = noor.LastName;

            Console.Write("Enter first name: ");
            noor.FirstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            noor.LastName = Console.ReadLine();

            Console.Write("Enter Birthday: ");
            DateTime personBirthday = Convert.ToDateTime(Console.ReadLine());
            noor.SetBirthday(personBirthday);


            //Console.Write("Enter age: ");
            //noor.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Employment status: ");
            noor.IsEmployed = Convert.ToBoolean(Console.ReadLine());

            if (noor.IsEmployed)
            {
                Console.Write("Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                noor.SetSalary(salary);
            }


            Console.WriteLine("");

            noor.EmployeeDetails();

            Console.Write("Age is: ");
            Console.WriteLine(DateUtil.Age(personBirthday));


        }


        // Static methods

    }
}