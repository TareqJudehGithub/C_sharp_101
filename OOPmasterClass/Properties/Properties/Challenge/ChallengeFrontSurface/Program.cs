namespace ChallengeFrontSurface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Length: ");
            int height = Convert.ToInt32(Console.ReadLine());
            // Instantiate a new object from class Box
            Box box = new Box(length: length, height: height);


            // call methods
            box.CalculateFrontSurface();
            box.DisplayInfo();

        }
    }
}