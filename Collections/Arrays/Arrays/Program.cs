// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays\n");

// Declaring fixed size arrays
int[] grades = new int[5];  // 5 spaces in memory address 0, 1, 2, 3, 4

// Adding values in arrays
grades[0] = 85;
grades[1] = 75;
grades[2] = 90;
grades[3] = 79;
grades[4] = 92;


foreach (int grade in grades)
{
    Console.WriteLine(grade);
}

Console.WriteLine("\n");
string[] grocery = { "Milk", "Cereal", "Bread" };
foreach (string item in grocery)
{
    Console.WriteLine(item.ToUpper());
}

Console.WriteLine("\n");

// Declaring variable sized array
string[] cars = new string[] { "GMC", "Chevrolet", "Cadillac" };

// Printing values in variable sized array
foreach (string car in cars)
{
    Console.WriteLine(car);
}


string[] names = new string[3];
// Adding values to variable sized array
for (int i = 0; i < names.Length; i++)
{
    Console.Write("Add new car:");
    names[i] += Console.ReadLine().ToLower();
}

// Printing values in variable sized array
foreach (string name in names)
{
    Console.WriteLine(name);
}




