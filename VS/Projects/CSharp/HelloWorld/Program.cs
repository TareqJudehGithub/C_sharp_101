// See https://aka.ms/new-console-template for more information

// Instantiating a new object from Random class storing it in a new variable
Random dice = new Random();

// Calling Next() method passing it two parameters (min, and max) values, saving 
// the result in a new variable
int diceOne = dice.Next(1, 6);

Console.WriteLine(diceOne);

