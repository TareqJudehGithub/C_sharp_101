using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators\n");

            // arithmetical operators
            decimal a = 10M;
            decimal b = 3M;

            decimal c = a + b;

            //Console.WriteLine(c);
            //Console.WriteLine(a % b);

            // assignment operators
            a += 20M;
            a -= 20M;
            Console.WriteLine(a);
            a %= 3M;
            Console.WriteLine(a);

            // comparison operators

            Console.WriteLine(a < b);
            Console.WriteLine(c < a);

            // logical operators
            Console.WriteLine(a == b);

            Console.WriteLine((a > b) && (b > c));

            Console.WriteLine($"The area of the circle = {CircleArea()}");


            FeetToInches();

        }

        // Methods

        static decimal CircleArea()
        {
            /*
             * This method calculates and returns the area of a circle providing it's radius.
             */


            //double radius = 20;
            //decimal area = Convert.ToDecimal(Math.PI * Math.Pow(radius, 2));

            decimal radius = 20;
            decimal area = 3.14159M * (radius * radius);
            return area;
        }

        static void FeetToInches()
        {
            /*
             * This method converts users height from feet and inches to centimeters.
             */

            decimal feet = 6.1M;
            decimal inches = 0M;
            decimal heightInInches = (feet * 12) + inches;

            decimal inchToCM = 2.54M;

            decimal heightInCM = heightInInches * inchToCM;

            Console.WriteLine($"{feet} foot and {inches} inches height is {heightInCM} centimeters");
        }

        static void NearestThouthands()
        {
            /* 
                Instructions
                If the number's last three digits are greater than or equal to 500; it should "round up" the number.
                If the number's last three digits are less than 500; it should "round down" the number.
                If the number is less than 500; it should round up to 1000.

                Eg:
                Input: 499  Output: 1000
                Input: 500  Output: 1000
                Input: 999  Output: 1000
                Input: 1000 Output: 1000
                Input: 1499 Output: 1000
            */
        }
    }
}
