using System;

namespace Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Parse()
            string textDigits = "123.456";
            float digits = float.Parse(textDigits);

            System.Console.WriteLine(digits);

            // TryParse
            string num;
            int parsedNum = 0;
            bool isParsed = false;

            do
            {
                System.Console.Write("Enter a number: ");
                num = Console.ReadLine();
                isParsed = Int32.TryParse(num, out parsedNum);
                if (isParsed)
                {
                    Console.WriteLine("Parsing is successful!");
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Error Parsing!");
                }
            }
            while (!isParsed);

        }
    }
}
