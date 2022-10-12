namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists in C sharp");

            // Declare a new list
            List<string> friendsList = new List<string>();

            // Declare a new list and initialize it with some elements
            List<string> family = new List<string> { "Noor", "Dina", "Leen" };

            // Adding new items/elements to a List
            friendsList.Add("Muhammad");
            friendsList.Add("Ali");
            friendsList.Add("Sarah");
            friendsList.Add("Adam");

            // combine two existing lists into one
            friendsList.AddRange(family);

            // Iterating into a list
            foreach (string name in friendsList) Console.WriteLine(Char.ToUpper(name[0]) + name.Substring(1));


            // Removing an element from a list
            friendsList.Remove("Adam");

            Console.WriteLine("\n");
            // methods calling
            AddMoreNames();
        }

        // Methods
        static void AddMoreNames()
        {
            /* 
             This program allows users to add names to a list
             */

            List<string> employees = new List<string>();
            string employeeName = string.Empty;

            while (!employeeName.Equals("quit"))
            {
                Console.Write("Enter a new employee name: ");
                employeeName = Console.ReadLine();

                if (!string.IsNullOrEmpty(employeeName) && !employeeName.Equals("quit"))
                {
                    employees.Add(employeeName);
                    Console.WriteLine($"Employee {employeeName} was add successfully!");
                }
                if (employeeName.Equals("quit"))
                {
                    Console.WriteLine("Good bye!");
                    break;
                }
            }

            foreach (string employee in employees)
            {
                Console.WriteLine($"Employee name: {employee}");
            }
            // OR
            Console.WriteLine("\n");
            for (int i = 0; i < employees.Count; i++) Console.WriteLine(employees[i]);
        }
    }
}