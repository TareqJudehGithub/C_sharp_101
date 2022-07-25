// See https://aka.ms/new-console-template for more information
Console.WriteLine("String and numbers Formatting\n");

string first = "Hello";
string second = "World";

// Composite Formatting
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
Console.WriteLine("\n");

//  String interpolation
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!\n");

// Currency formatting
decimal foodBill = 25.7517m;
Console.WriteLine($"Food bill: {foodBill:C2}\n");

// Numbers formatting
decimal bigNum = 1584195.1254687m;
Console.WriteLine($"clean, formatted number = {bigNum:N3}\n");

// Percentage formatting

decimal total = 25.458m;
decimal tax = 0.16m;
Console.WriteLine($"Tax amount = {total:N2} * {tax:P0} = {total * tax:N2}");
Console.WriteLine($"Total after tax = {total:N2} +  {total * tax:N2} = {total + (total * tax):N2}\n");


// exercise
int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total2 = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Product: {productMeasurement:N3} mg");

Console.WriteLine($"Subtotal: {subtotal:C} ");
Console.WriteLine($"Tax: {taxPercentage:P2}");

Console.WriteLine($"Total: {total2:C} ");

