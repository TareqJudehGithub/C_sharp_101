// See https://aka.ms/new-console-template for more information
Console.WriteLine("Format alphanumeric data for presentation challenge\n");



string customerName = "Mr. Jones";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0002m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($@"
Dear {customerName},
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.

Our new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.

");

Console.WriteLine("Here's a quick comparison:\n");


string comparisonMessage = "";


// Your logic here


comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);
comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);


Console.WriteLine(comparisonMessage);

Console.WriteLine($"{currentReturn} \t{newReturn:P}");
