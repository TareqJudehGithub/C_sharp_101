namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryParse\n");

            string numInStr = "1000.751";
            int parsedValue;

            //try
            //{
            bool success = int.TryParse(numInStr, out parsedValue);
            if (success)
            {
                Console.WriteLine($"Parsing was successful! number {parsedValue}");
            }
            else
            {
                Console.WriteLine("Parsing failed!");
            }
            //}
            //catch (Exception error)
            //{
            //    Console.WriteLine(error);
            //}

        }
    }
}
