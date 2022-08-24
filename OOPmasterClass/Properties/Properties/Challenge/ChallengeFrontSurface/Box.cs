namespace ChallengeFrontSurface
{
    internal class Box
    {
        internal int Length { get; set; }
        internal int Height { get; set; }
        internal int FrontSurface
        {
            get
            {
                return Length * Height;
            }
        }

        // Constructor
        internal Box(int length, int height)
        {
            Length = length;
            Height = height;
        }


        // Methods

        internal int CalculateFrontSurface()
        {
            /*
             This method calculate front surface of a box based on user's length and height inputs.*/

            //Console.Write("Length: ");
            //length = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Length: ");
            //height = Convert.ToInt32(Console.ReadLine());

            return FrontSurface;
        }

        internal void DisplayInfo()
        {
            /*
             This method display user's inputs, calculation process and result of a box front surface.
            */
            Console.WriteLine($"Front surface = length {Length}cm * height {Height}cm = {Length * Height}cm");
        }
    }
}
