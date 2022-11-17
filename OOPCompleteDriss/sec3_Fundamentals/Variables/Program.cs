// See https://aka.ms/new-console-template for more information

namespace Variables
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables\n");

            // Object data type
            // can store anything
            // not recommended, affects performance.

            // Implicit types variables
            // makes declaring variables easier
            // we use the 'var' keyword to implicitly declare a variable
            // Type Inference: 'var' keyword determines the variables assigned value.
            // implicit type variables must be initialized.
            // Implicit type variables cannot be initialed with a null.
            var myBool = true;
            var age = 47;
            var myName = "John Smith";


        }
    }
}
