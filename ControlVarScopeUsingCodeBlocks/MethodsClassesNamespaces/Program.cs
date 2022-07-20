// See https://aka.ms/new-console-template for more information

namespace MethodsClassesNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Methods in c#\n");
            string word = "Microsoft Learn";

            Console.WriteLine(Reverse(word));
        }
        static string Reverse(string message)
        {
            char[] letter = message.ToCharArray();
            Array.Reverse(letter);
            return new string(letter);
        }
    }
}

