namespace InheritanceChallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InheritanceChallenge2\n");

            // Instances
            Boss CEO = new Boss(firstName: "john", lastName: "smith", position: "CEO", salary: 5000, "Chevrolet");
            Boss salesMng = new(firstName: "sarah", lastName: "adams", position: "Sales Manager", salary: 1500, "Toyota");

            // Method calls
            Console.WriteLine(CEO.ToString());
            Console.WriteLine(salesMng.ToString());
            Console.WriteLine(salesMng.CapitalizeString("hello world"));
        }
    }
}