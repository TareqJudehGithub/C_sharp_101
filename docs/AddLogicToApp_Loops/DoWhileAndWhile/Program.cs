// See https://aka.ms/new-console-template for more information
Console.WriteLine("do-while loop\n");

int number = 0;

do
{
    Console.WriteLine($"number before incrementing: {number}");
    number++;
    Console.WriteLine($"number inside do block of code is: {number}");
}
while (number < 3);


Console.WriteLine("write code that will keep generating random numbers between 1 and 10 until we generate the number 7. \n");

Random dice = new Random();
int diceRoll = 0;

do
{

    Console.WriteLine($"Roll the dice! {diceRoll}");
    diceRoll = dice.Next(1, 11);
}
while (diceRoll != 7);


Console.WriteLine("Write a while statement that iterates only while a random number is greater than some value\n");

while (diceRoll >= 3)
{
    diceRoll = dice.Next(1, 11);
    Console.WriteLine($"{diceRoll} is still greater than 3");
}
Console.WriteLine(diceRoll + " End of while loop\n");

Console.WriteLine("continue keyword");
int randNum = dice.Next(1, 7);

do
{
    randNum = dice.Next(1, 7);
    if (randNum >= 4) continue;
    Console.WriteLine(randNum);
}
while (randNum != 3);




