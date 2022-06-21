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

int roll = dice(1, 6);

// Declaring a sum variable to keep track of user rolls total

int counter;

// first roll 
int firstRoll = roll;
counter += firstRoll;
Console.WriteLine(firstRoll);

// first roll 
int secondRoll = roll;
counter += secondRoll;
Console.WriteLine(secondRoll);

// first roll 
int thirdRoll = roll;
counter += thirdRoll;
Console.WriteLine(thirdRoll);

Console.WriteLine($"counter = {counter}");

