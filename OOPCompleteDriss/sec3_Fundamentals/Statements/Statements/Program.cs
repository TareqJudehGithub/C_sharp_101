// See https://aka.ms/new-console-template for more information

namespace Statements{
  class Program 
  {
    static void Main(string[] args)
    {
      string greet = "Hello, World!";
      Console.WriteLine($"{greet}\n");

      Console.Write("What is your name? ");
      string name = Console.ReadLine();

      Console.WriteLine($"Your name is {name}");
      Console.SetWindowSize(50, 10);
    }
  }
}

