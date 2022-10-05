// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 
Multi-line comment
 */
// One line comment


// Declare a variable
string fullName = string.Empty;
decimal salary = 0;

// Allow user input, and store in variables
Console.Write("Type in your name: ");
fullName = Console.ReadLine();

// print contents of var/users input
fullName = Char.ToUpper(fullName[0]) + fullName.Substring(1);

Console.WriteLine(fullName);


// Variables And Data Types
int age;

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your Gender: ");
char gender = Convert.ToChar(Console.ReadLine());

Console.Write("Do you work?: ");
bool isWorking = Convert.ToBoolean(Console.ReadLine());

if (isWorking)
{
    Console.Write("Enter your Salary: ");
    salary = Convert.ToDecimal(Console.ReadLine());
}


Console.WriteLine($"Name: {fullName}\n" +
    $"Age: {age}\n" +
    $"Gender: {Char.ToUpper(gender)}\n" +
    $"Employed: {isWorking}\n" +
    $"Salary: {salary}\n");

