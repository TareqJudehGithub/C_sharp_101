// See https://aka.ms/new-console-template for more information
Console.WriteLine("Challenge 1\n");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

double total = 0;
string msg = string.Empty;
double dblValue = 0;

foreach (string value in values) {
    bool isInteger = double.TryParse(value, out dblValue);
    if (isInteger) total += dblValue;
    else msg += value;
}

Console.WriteLine(msg);
Console.WriteLine(total);


Console.WriteLine("\nChallenge 2\n");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int result1 = Convert.ToInt32((decimal)value1/ value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");



