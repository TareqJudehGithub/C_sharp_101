// See https://aka.ms/new-console-template for more information

// Variable Declaration and types

string fullName = String.Empty; // Empty string
int age;
double salary;
char gender = char.MinValue;
bool isWorking;

Console.Write("Enter your name: ");
fullName = Console.ReadLine();

Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Your gender: ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are your currently working? (true/false) ");
isWorking = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($@"Hello, {fullName}!
You're {age} years old
You salary is ${salary}
Your gender is {gender}
And you're work status is: {isWorking}");

  





