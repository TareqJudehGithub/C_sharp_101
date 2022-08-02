using System;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // if-else statements
            // IfElse();

            // while loop
            //WhileLoop();

            // for loop
            //ForLoop();

            //GotoStatement();
            LoopAssignment();

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
            Console.WriteLine("");
            LargestNum();

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
            */

            decimal heightInInch = 76.8M;
            decimal heightInCM = heightInInch * 2.54M;

            if (heightInCM < 150) Console.WriteLine("Dwarf");
            else if (heightInCM >= 150 && heightInCM < 165) Console.WriteLine("Average height");
            else if (heightInCM >= 165 && heightInCM < 195) Console.WriteLine("Tall");
            else Console.WriteLine("Abnormal height");
        }
        static void LargestNum()
        {
            /* 
             This method compares three numbers and outputs the largest between value between the three.
             */

            int num1 = 60;
            int num2 = 45;
            int num3 = 123;

            int largestNum = 0;

            if (num1 > largestNum) largestNum = num1;
            if (num2 > largestNum) largestNum = num2;
            if (num3 > largestNum) largestNum = num3;

            Console.WriteLine($"The largest number is {largestNum}");
        }

        static void WhileLoop()
        {
            int num = 1;

            while (num < 10)
            {
                Console.WriteLine($"number = {num}");
                num++;
            }
        }
        static void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i = {i}");
            }
            Console.WriteLine("");
            string greet = "hello world";
            for (int i = greet.Length - 1; i >= 0; i--)
            {
                Console.Write(greet[i]);
            }
            Console.WriteLine("");
        }

        static void GotoStatement()
        {
            /*
             goto jumps from 1 statement to another.
             */

            Console.WriteLine("100");
            Console.WriteLine("200");
            goto mylabel;
            Console.WriteLine("300");
            Console.WriteLine("400");
            Console.WriteLine("500");
            Console.WriteLine("600");
        mylabel:
            Console.WriteLine("700");
            Console.WriteLine("800");

        }
        static void LoopAssignment()
        {
            /* 
                Write a C# program to print the following output:

                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                1 2 3 4 7 8 9 10
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3 2 1
                10 9 8 7 6 5 4 3
                10 9 8 7 6 5 4 3 2 1
                1 2 3 4 5 6 7 9 10

                Each number should be printed by using the loop variable.
                Don't print full line at-a-time as string.
                For example, don't write statements as:

                System.Console.WriteLine("1 2 3 4 7 8 9 10");

                Use for loop, break and continue statements to bring the output.

             */
            int counter = 0;
            while (counter < 3)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i == 5 || i == 6) continue;
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                counter++;
            }

            counter = 0;
            while (counter < 2)
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                counter++;
            }

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
                if (i == 3) break;
            }
            Console.WriteLine("");

            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            for (int i = 1; i <= 10; i++)
            {
                if (i == 8) continue;
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
    }

}

