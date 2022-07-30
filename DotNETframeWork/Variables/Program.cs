using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables\n");

            // Declaring values
            int a = 100;    // Initialize an integer variable named a with value 100;

            string studentName = "Scott";
            int age = 20;

            // print values
            Console.WriteLine(a);
            Console.WriteLine($"Hey, {studentName}! You're {age} old!");
        }
    }
}
