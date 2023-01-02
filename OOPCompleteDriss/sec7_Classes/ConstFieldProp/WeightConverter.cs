namespace ConstFieldProp
{
    internal class WeightConverter
    {
        private const float ACCELERATION = 9.8F;

        internal static float Convert(float mass = 10f)
        {
            return mass * ACCELERATION;
        }
    }
}
