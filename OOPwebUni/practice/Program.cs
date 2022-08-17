namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP\n");

            // Instantiate a new object from class Human;
            Human denis = new Human();
            Human micheal = new Human();

            // access variables from outside this class, using 'public' access modifier
            denis.firstName = "Denis";
            denis.lastName = "Rodman";
            micheal.firstName = "Micheal";
            micheal.lastName = "Adams";

            // calling a method from Human class.
            denis.IntroduceMySelf();
            micheal.IntroduceMySelf();


        }
    }
}