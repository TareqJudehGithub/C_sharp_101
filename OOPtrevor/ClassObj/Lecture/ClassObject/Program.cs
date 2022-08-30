// See https://aka.ms/new-console-template for more information

namespace ClassObject
{
	class Program
	{
		static void Main(string[] args)
		{
			// Instantiate new objects from Person class
			Person ali = new Person();

			// Access object properties
			Console.Write("First Name: ");
			ali.FirstName = Console.ReadLine();

			Console.Write("Last Name: ");
			ali.LastName = Console.ReadLine();

			Console.Write("Age: ");
			ali.Age = Convert.ToInt32(Console.ReadLine());

			Console.Write("Salary: ");
			double salary = Convert.ToDouble(Console.ReadLine());
			ali.SetSalary(salary);

			// Call methods
			ali.DisplayInfo();
			ali.YearOfBirth(ali.FirstName);

			// Console.WriteLine($"Property Year: {ali.Year}");

		}
	}
}


