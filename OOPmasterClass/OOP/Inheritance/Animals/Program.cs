namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("virtual - override modifiers\n");

            // Instantiate new objects from Animal base class
            Dog rex = new Dog(name: "Rex", age: 4);

            // Calling derived class methods
            rex.AnimalInfo();
            rex.Eat();
            rex.MakeSound();
            rex.play();
        }
    }
}