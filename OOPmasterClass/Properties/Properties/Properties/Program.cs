namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new objects:
            Box box = new Box();

            box.CalculateVolume();

            // Calling method
            box.DisplayInfo();
        }
    }
}