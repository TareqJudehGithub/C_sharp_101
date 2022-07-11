// See https://aka.ms/new-console-template for more information

namespace Coding.Exercise
{
    public class Method
    {
        // Place for your methods



        public static void Main(String[] args)
        {
            // We encourage you to test your code with different strings,
            // but don't forget to put the default string back at the end of your testing.
            string s = "HeY ThErE !";

            /// Change nothing down here 
            s = LowUpper(s);
            Console.WriteLine(s);
            Count(s);
        }
        public static string LowUpper(string text)
        {

            return text.ToLower() + text.ToUpper();
        }
        public static void Count(string text)
        {
            Console.WriteLine($"The amount of characters is {text.Count()}");
        }
    }
}


