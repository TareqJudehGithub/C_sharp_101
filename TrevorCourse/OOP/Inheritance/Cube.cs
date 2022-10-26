namespace Inheritance
{
    internal class Cube : Shape
    {
        internal double Width { get; set; }

        // Constructors       

        // Default constructor
        internal Cube()
        {

        }
        // Parameterized constructor
        public Cube(double width, double height, double length)
        {
            this.Width = width;
            this.Height = height;
            this.Length = length;
        }
        internal double getArea()
        {
            return Length * Width;
        }
        internal double GetVolume()
        {
            return Length * Width * Height;
        }
    }
}
