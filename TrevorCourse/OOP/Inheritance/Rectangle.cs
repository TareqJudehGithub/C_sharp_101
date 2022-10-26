namespace Inheritance
{
    internal class Rectangle : Shape, IShape
    {
        // Properties
        internal double Width { get; set; }

        // Constructors
        internal Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        // Methods
        public double getArea()
        {
            return Length * Width;
        }
    }
}
