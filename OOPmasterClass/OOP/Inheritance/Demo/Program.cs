namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo\n");

            // Instantiate a new object
            Post post1 = new Post();
            Post post2 = new Post("Hello thank you for the invite!", true, "Gary Philip");
            Post post3 = new Post("Thanks for the birthday wishes", true, "John Smith");
            ImagePost image1 = new ImagePost("Shoes Images", "Sarah Adams", "http://www.images.com", true);

            // Methods
            Console.WriteLine(post1.ToString());  // display object details`         
            Console.WriteLine(post2.ToString());  // display object details`         
            Console.WriteLine(post3.ToString());
            Console.WriteLine(image1.ToString());
        }
    }
}