namespace Volume
{
    internal class Box
    {
        // fields/properties

        private int Length { get; set; }
        private int Height { get; set; }
        private int Width { get; set; }
        private int Volume
        {
            get
            {
                return this.Length * this.Height * this.Width;
            }
            set
            {
                this.Volume = value;
            }
        }

        // methods

        internal int CalculateVolume()
        /* 
         This method calculates a volume of a box based on user inputs for length, height, and width.
         */
        {
            Console.WriteLine("This program calculates the volume of a box.\nPlease enter box dimensions below:");
            Console.Write("Length: ");
            this.Length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Height: ");
            this.Height = Convert.ToInt32(Console.ReadLine());

            Console.Write("Width: ");
            this.Width = Convert.ToInt32(Console.ReadLine());

            return this.Volume;
        }
        internal void DispalayInfo()
        {
            Console.WriteLine($"volume = Length {this.Length} * Height {this.Height} * Width {this.Width}\n" +
                $"Volume = {this.Length * this.Height * this.Width}");
        }
    }
}
