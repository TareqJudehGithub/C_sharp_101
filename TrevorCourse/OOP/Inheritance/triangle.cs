namespace Inheritance
{
    internal class Triangle : Shape
    {
        // Properties
        internal double Hypotenuese { get; set; }

        // Constructors

        public Triangle(double length, double height)
        {
            this.Length = length;
            this.Height = height;
        }
        public Triangle(double hypo)
        {
            Hypotenuese = hypo;
        }

        // Methods
        internal double GetArea()
        {
            return 0.5 * (Length * Height);
        }

    }
}