// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Apples Store");

int numOfApples = 0;
int numOfCustomers = 0;
double profit = 0;

Console.WriteLine("You picked 500 apples from an apple orchard");
//Update number of apples.
numOfApples += 500;

Console.WriteLine("Time for business! You're selling each apple for 40 cents");
//Make a price variable. Set it equal to 40 cents. 
double price = 0.4;

System.Console.WriteLine("One customer walked in. He bought 4 apples!");
//Update number of apples.
numOfApples -= 4;
//Update number of customers;
numOfCustomers++;

//Update profit
profit += 4 * price;

Console.WriteLine("Another customer walked in. He bought 20 apples!");
//Update number of apples;
numOfApples -= 20;
//Update number of customers;
numOfCustomers++;
//Update profit
profit += 20 * price;

Console.WriteLine("Another customer walked in. She bought 200 apples!");
//Update number of apples;
numOfApples -= 200;
//Update number of customers;
numOfCustomers++;
//Update profit
profit += 200 * price;

Console.WriteLine($"Wow! So far, you made: ${profit}");
Console.WriteLine($"{numOfCustomers} customers love your apples.");
Console.WriteLine($"You have {numOfApples} apples left. We'll sell more tomorrow!\n");


