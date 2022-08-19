namespace Properties
{
    public class Box
    {
        private int length;
        private int height;
        // private int width;
        private int volume;

        // properties:
        private int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }
        private int Width { get; set; }    // a faster way to declare a property (type prop)


        // Setters

        private void SetLength(int value)
        {
            this.length = value;
        }
        private void SetHeight(int value)
        {
            this.height = value;
        }
        //private void SetWidth(int value)
        //{
        //    this.width = value;
        //}

        // Getters
        private int GetLength()
        {
            return this.length;
        }
        private int GetHeight()
        {
            return this.height;
        }
        //private int GetWidth()
        //{
        //    return this.width;
        //}
        private int GetVolume()
        {
            return this.length * this.height * this.Width;
        }

        // Methods
        internal int CalculateVolume()
        /*
         This method calculate the volume based on user entries.
         */
        {
            Console.Write("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            SetLength(length);

            Console.Write("Height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Height = height;

            Console.Write("Width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Width = width; ;

            return GetVolume();
        }

        internal void DisplayInfo()
        {
            /*
             This method displays user entries and the result for calculating the volume.
             */

            volume = length * height * Width;
            System.Console.WriteLine($"Length: {GetLength()}, Height: {GetHeight()}, Width: {Width}\n" +
                $"Volume: {GetLength()} * {GetLength()} * {Width} =  {GetLength() * GetHeight() * Width}");
        }
    }
}
