// See https://aka.ms/new-console-template for more information
Console.WriteLine("String Manipulation");

string firstName = "John";
string lastName = "Smith";
DateTime date = DateTime.Now;


// Print to string
Console.WriteLine($"My first name is {firstName}\n");


// Concatenation & interpolation
Console.WriteLine("My name is {0} {1}.\n", firstName, lastName);
Console.WriteLine($"My name is {firstName} {lastName}\n");

// String Length
int nameLength = firstName.Length;
Console.WriteLine($"Your first name is {nameLength} characters long.\n");


// Replace String parts
string newFirstName = firstName.Replace("John", "John K.");
Console.WriteLine($"Your new first name is {newFirstName}\n");


// Append to other string variable
string fullName = newFirstName + " " + lastName;
Console.WriteLine($"Your fill name is {fullName}\n");


// Split string
string[] splitFullName = fullName.Split(' ');
for (int i = 0; i < splitFullName.Length; i++)
{
    Console.WriteLine(splitFullName[i]);
}



// Compare String
Console.WriteLine("String manipulation: \n");
string nullVariable = null;
string emptyString = "";
string whiteSpace = " ";


Console.WriteLine(string.IsNullOrEmpty(nullVariable));      // true
Console.WriteLine(string.IsNullOrWhiteSpace(emptyString));  // true
Console.WriteLine(string.IsNullOrWhiteSpace(whiteSpace));   // true
Console.WriteLine(string.IsNullOrWhiteSpace(firstName));    // true

int stringCompare = string.Compare("hello", "hello");       // 0 => equal
Console.WriteLine(stringCompare);
int stringCompare2 = string.Compare("hello", "Hello");       // -1 => not equal

// convert to string
int number = 123;
Console.WriteLine(number + Convert.ToString(number)); // 123123


