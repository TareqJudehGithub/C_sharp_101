namespace Animals
{
    internal class Animal
    // This is the base class
    {
        // properties
        internal string Name { get; set; }
        internal int Age { get; set; }
        internal bool IsHungry { get; set; }
        internal bool IsInGoodMood { get; set; }

        // Constructor
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }


        // Methods
        internal virtual void AnimalInfo()
        {
            Console.WriteLine($"Name: {Name}\n" +
                $"Age: {Age}\n");
        }
        internal virtual void MakeSound()
        {
            Console.WriteLine("The animal is making a sound:");
        }
        internal virtual void Eat()
        {
            if (IsHungry) Console.WriteLine($"{Name} is hungry and needs to eat\n");
            else Console.WriteLine($"{Name} is not hungry now.\n");
        }
        internal virtual void play()
        {
            if (IsInGoodMood) Console.WriteLine($"{Name} is in a good mood and playing.");
            else Console.WriteLine($"{Name} does not feel like playing right now.");
        }
    }
}
