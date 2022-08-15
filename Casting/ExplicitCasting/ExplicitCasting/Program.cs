namespace ExplicitCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            float b;

            // convert a value to b.

            b = (float)a;
            System.Console.WriteLine(b);    // 100 

            b = 100.123F;

            int c = (int)b;
            System.Console.WriteLine(c);    // 100  we lose all values after the decimal point.    
        }
    }
}
