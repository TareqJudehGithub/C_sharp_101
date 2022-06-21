// See https://aka.ms/new-console-template for more information
/* 
Roll the dice puzzle

 - If the user roll 6 side of dice 3 times in row, the user wins.
 - If the user rolls any number twice, he/she gets 2 bonus points.
 - If the user rolls any number 3 times in a row, he/she gets 6 points.
 - If the sum of three dice rolls, plus any point bonuses, is 15 or greater
   you win the game. Otherwise, you lose.

*/

// Instantiating a new object from Random class
Random dice = new Random();


// Declaring a sum variable to keep track of user rolls total
int sum = 0;

// first roll 
int firstRoll = dice.Next(1, 6);
sum += firstRoll;
Console.WriteLine(firstRoll);

// first roll 
int secondRoll = dice.Next(1, 6);
sum += secondRoll;
Console.WriteLine(secondRoll);

// // first roll 
int thirdRoll = dice.Next(1, 6);
sum += thirdRoll;
Console.WriteLine(thirdRoll);
Console.WriteLine($"Dice rolls: {firstRoll} + {secondRoll} + {thirdRoll} = {firstRoll + secondRoll + thirdRoll}");
Console.WriteLine("");


if ((firstRoll == secondRoll) && (secondRoll == thirdRoll) && (firstRoll == thirdRoll)) {
  Console.WriteLine("6 bonus points added!");
  sum += 6;
}
// Check if first two rolls are equal
else if ((firstRoll == secondRoll) || (secondRoll == thirdRoll) || (firstRoll == thirdRoll)) {
  Console.WriteLine("2 bonus points added!");
  sum += 2;
}

// Win condition
if (sum >= 15) {
  Console.WriteLine($"You collected {sum} points! You win!");
}
else {
  Console.WriteLine($"You collected {sum} points! Sorry but you lose :(");
}

Console.WriteLine($"sum = {sum}");

