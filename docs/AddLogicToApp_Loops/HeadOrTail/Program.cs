// See https://aka.ms/new-console-template for more information
Console.WriteLine("Head or Tail Challenge\n");


/* This programs displays either heads or tails based on coin flip.*/

Random coin = new Random();

int flipcoin = coin.Next(1, 3);

string result = flipcoin == 1 ? "Heads" : "Tail";

Console.WriteLine(result);