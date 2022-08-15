namespace TypeConversionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variables
            byte a = 10;
            int b = 10;
            string c = "10.34";
            decimal d = 11.56M;

            // Implicit Casting
            short aa = a;

            // Explicit Casting
            short bb = (short)b;

            // Parse 
            double cToDouble = double.Parse(c);

            //TryParse
            bool isDecimal = decimal.TryParse(c, out decimal cToDecimal);
            if (isDecimal) System.Console.WriteLine("Converting was successful!");
            else System.Console.WriteLine("Error converting string to decimal.\nCheck code format.");

            // Conversion Methods
            string dToString = System.Convert.ToString(d);

            // print out all converted values
            System.Console.WriteLine(aa);
            System.Console.WriteLine(bb);
            System.Console.WriteLine(cToDouble);
            System.Console.WriteLine(cToDecimal);
            System.Console.WriteLine(dToString);
        }
    }
}

/*
 You have the following values to convert:

byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
int b = 10; //Convert this value into "short" type (assign into another short type of variable)
string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
decimal d; //Convert this value into "string" type (assign into another string type of variable)
And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.



You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

Implicit Casting

Explicit Casting

Parse or TryParse (as suggested above)

Conversion Methods
 */
