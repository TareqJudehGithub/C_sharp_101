// See https://aka.ms/new-console-template for more information

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections: Arrays & Lists\n");

            MyList();
        }

        // Methods

        static void MyList()
        {
            var names = new List<string> { "Sarah", "Ali", "Adam", "Anna"};
            foreach (string name in names)
	        {
                Console.WriteLine(name);
	        }
        }
    }
}

