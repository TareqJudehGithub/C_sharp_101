namespace Animals
{
    internal class Dog : Animal
    {
        // Constructor
        public Dog(string name, int age) : base(name: name, age: age)
        {
            IsHungry = true;
            IsInGoodMood = false;
        }

        // Methods


        internal override void Eat()
        {
            // base.MethodName() copy the base class method block of code.
            base.Eat();
        }
        internal override void MakeSound()
        {
            Console.WriteLine($"{Name} is barking! WOOF WOOF!\n");
        }
        internal override void play()
        {
            if (IsInGoodMood) base.play();
            else Console.WriteLine($"You need to show your dog {Name} some love!\n");
        }
    }
}
