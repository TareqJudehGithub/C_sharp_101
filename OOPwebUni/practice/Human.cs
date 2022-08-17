namespace OOP
{
    // This class is blueprint for a data type
    internal class Human
    {
        // member variable
        public string firstName = string.Empty;     // Empty or we could set a default value.
        public string lastName = string.Empty;

        // member method
        public void IntroduceMySelf()
        {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}!");
        }
    }
}
