namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            // call set accessor of indexer
            car[0] = "GMC";   // "GMC" will override "BMW" in the _brands array.

            // print _brands first element (call get accessor of indexer)
            System.Console.WriteLine($"first element: {car[0]}");
        }
    }
}
