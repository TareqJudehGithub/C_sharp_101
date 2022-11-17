// See https://aka.ms/new-console-template for more information

namespace Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Helper.IsEven(i)) Console.WriteLine($"{i} is an even value");
                else Console.WriteLine($"{i} is an odd value");
            }
        }
    }
    static class Helper
    {
        static internal bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
