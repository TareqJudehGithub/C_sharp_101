namespace FloatingPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Floating Points\n");


            // float

            float f = 0.2f;
            Console.WriteLine($"{nameof(f)}:{f:G9}");

            // double
            double d = 0.2d;
            Console.WriteLine($"{nameof(d)}:{d:G9}");
            // decimal

            bool isEqual;

            if (f == d)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
            Console.WriteLine($"{nameof(isEqual)} = {isEqual}");

            decimal m = 15.2m;

            int comparsion = d.CompareTo(d);

            Console.WriteLine(comparsion.GetType());

        }
    }
}