using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Manipulation in C#");


            string name = "Alfonso";
            int age = 31;
            string mood = "happy";

            // String concatenation
            Console.WriteLine("My name is " + name + ". I'm " + age + "Years old.");

            // String formatting using indexes
            Console.WriteLine("I'm {0}, {1} years old, and I'm {2}", name, age, mood);

            // Verbatim string @

        }
    }
}

