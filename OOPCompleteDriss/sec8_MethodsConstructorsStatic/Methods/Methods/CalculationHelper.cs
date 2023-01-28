namespace Methods
{
    internal class CalculationHelper
    {
        // Instance method
        public int Square(int integer = 10)
        {

            return integer * integer;
        }
        // Method Overload: a method with the same name that has different set of params
        public float Square(float num = 1.5f)
        {
            return num * num;
        }
        // Static method
        public static double Cubed(double num)
        {
            return Math.Pow(num, 3);
        }

        public void SquareByValue(int num)
        {
            num *= num;
            Console.WriteLine($"{nameof(num)} squared by value = {num}");
        }
        public void SquareByRef(ref int num)
        {
            num *= num;
            Console.WriteLine($"{nameof(num)} squared by reference = {num}");
        }
    }
}

