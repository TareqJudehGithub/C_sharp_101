// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conditional Statements");

Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

// if statements (== < > <== >== !=)
if (firstNum > secondNum)
{
    Console.WriteLine($"{firstNum} is greater than {secondNum}");
}
else if (firstNum == secondNum)
{
    Console.WriteLine($"{firstNum} is the same as {secondNum}");
}
else
{
    Console.WriteLine($"{firstNum} is lesser than {secondNum}");
}
// switch statement
Console.Write("What's today's weather? ");
string weather = Console.ReadLine();

switch (weather)
{
    case "sunny":
        Console.WriteLine("Wear a T-shirt today!");
        break;
    case "cold":
        Console.WriteLine("Wear a jacket it is going to be cold today!");
        break;
    case "rain":
        Console.WriteLine("Take an umbrella!");
        break;
    default:
        Console.WriteLine("Check the weather forecast before you go out today.");
        break;
}

// Ternary Operator
Console.Write("Guess my secret number: ");
int secretNum = Convert.ToInt32(Console.ReadLine());
var yourGuess = secretNum == 25 ? $"You guessed {secretNum}! Correct!" : $"{secretNum} is a wrong answer.";

Console.WriteLine(yourGuess);

Console.WriteLine(yourGuess.Equals("Hello!"));


