using System;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // if-else statements
            IfElse();

        }
        static void IfElse()
        {
            int age = 47;

            if (age >= 18) Console.WriteLine("You're permitted to obtain a driving license.");
            else Console.WriteLine("You're still not old enough to obtain a driving license.");

            Console.WriteLine("");

            int score = 34;
            char grade = ' ';

            if (score >= 85) grade = 'O';
            else if (score >= 60 && score < 85) grade = 'A';
            else if (score >= 50 && score < 60) grade = 'B';
            else if (score >= 35 && score < 50) grade = 'C';
            else grade = 'F';

            Console.WriteLine($"Your grade is {grade}");

            Console.WriteLine("");
            HeightCategories();
        }

        static void HeightCategories()
        {
            /* 
                 Height categories:
                    Height is less than 150 cm = "Dwarf"
                    Height is between 150 cm and 165 cm = "Average height"
                    Height is between 165 cm and 195 cm = "Tall"
                    Height is above 195 cm = "Abnormal height"

                 Note: 1 inch = 2.54 centimeter
                 You need to convert the input value (inches) into centimeters.

                  Eg:
                   Input: 75
                   Output: Tall
            */

            decimal heightInInch = 76.8M;
            decimal heightInCM = heightInInch * 2.54M;

            if (heightInCM < 150) Console.WriteLine("Dwarf");
            else if (heightInCM >= 150 && heightInCM < 165) Console.WriteLine("Average height");
            else if (heightInCM >= 165 && heightInCM < 195) Console.WriteLine("Tall");
            else Console.WriteLine("Abnormal height");
        }
    }
}

