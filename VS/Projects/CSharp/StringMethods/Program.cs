using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Methods!");

            string firstName = "  John  ";
            string lastName = "Smith";

            Console.WriteLine(firstName.IndexOf('o'));

            string fullName = string.Concat(" ", firstName, lastName, " ");
            Console.WriteLine(fullName);
            Console.WriteLine(firstName.Substring(1));
            Console.WriteLine(firstName);
            Console.WriteLine(firstName.Trim());
            Console.WriteLine(string.Format("My surname is {0}", lastName));


        }
    }
}
