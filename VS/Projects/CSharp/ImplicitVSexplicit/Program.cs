namespace ImplicitVSexplicit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implicit vs Explicit casting");

            // Implicit casting - automatic casting (smaller to bigger data type)
            int salary = 1000;
            double salaryDbl = salary;

            Console.WriteLine(salaryDbl);

            // explicit casting - manual conversion 
            double tax = 152.68;
            int taxInt = (int)tax;
            Console.WriteLine(taxInt);

            // Type conversion
            string convertTax = tax.ToString();
            Console.WriteLine(convertTax);

            // convert salary int to string
            string salaryText = salary.ToString();
            Console.WriteLine(salaryText);
            Console.WriteLine(salaryText.GetType());

            int age = 47;
            Console.WriteLine($"Data type for {age} is {age.GetType()}");

            // Parse string to int
            string stringNo1 = "15";
            string stringNo2 = "25";
            Console.WriteLine(stringNo1 + stringNo2);
            int integerNo1 = Convert.ToInt32(stringNo1);
            int integerNo2 = Convert.ToInt32(stringNo2);
            Console.WriteLine(integerNo1 + integerNo2);

            Console.WriteLine("Assignment 1\n");
            string stringForFloat = "0.85"; // data type should be float
            string stringForInt = "12345"; // data type should be int

            double dblToInt = Convert.ToDouble(stringForFloat);
            float dToF = (float)dblToInt;
            Console.WriteLine(dToF.GetType());
            

            int strToInt = Convert.ToInt32(stringForInt);
            Console.WriteLine(strToInt);


        }
    }
}