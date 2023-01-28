namespace Structures
{
    internal struct Point
    {
        // public int MyProperty { get; set; } = 10; This will return a compile error.
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.y = y;
        }
        public Point()
        {
            Console.WriteLine("This is a parameter less constructor");
        }

        // returns string representation of the object
        public override string ToString()
        {
            return $"X = {x}, Y = {y}, Z = {z}";
        }
    }

}
