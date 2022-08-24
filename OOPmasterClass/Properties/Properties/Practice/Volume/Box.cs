namespace Volume
{
    internal class Box
    {
        // fields/properties

        private int Length { get; set; }
        private int Height { get; set; }
        private int Width { get; set; }

        // We don't set Volume because it is calculated.
        private int Volume
        {
            get
            {
                return Length * Height * Width;
            }
        }

        // Constructors
        public Box(int length, int height, int width)
        {
            Length = length;
            Height = height;
            Width = width;
        }
        public Box()
        {

        }


        // methods
        internal int CalculateVolume()
        /* 
         This method calculates a volume of a box based on user inputs for length, height, and width.
         */
        {
            Console.WriteLine("This program calculates the volume of a box.\nPlease enter box dimensions below:");

            Console.Write("Length: ");
            Length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            Height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width: ");
            Width = Convert.ToInt32(Console.ReadLine());

            return Volume;
        }
        internal void DispalayInfo()
        {
            /*
             This method displays user entries and volume result.
             */
            Console.WriteLine($"volume = Length {Length} * Height {Height} * Width {Width}\n" +
                $"Volume = {Length * Height * Width}");
        }
    }
}
