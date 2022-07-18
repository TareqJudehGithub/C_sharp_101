// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lists\n");

// Declaring empty lists
List<string> names = new List<string>();

// Adding values to a list
names.Add("ali");
// Or
names[0] = "sarah"; // not recommended; because I have to know the exact address.

// Removing items from a list

names.Remove("ali");
names.Remove("sarah");

string? name = string.Empty;

while (!name.Equals("-1"))
{
    Console.Write("Enter new name: ");
    name = Console.ReadLine();

    if (!string.IsNullOrEmpty(name) && !name.Equals("-1")) // if input is not empty or -1
    {
        names.Add(name);
        Console.WriteLine($"{name} Added successfully!");
    }
}

// Print values in a list
// Using foreach loop
foreach (string item in names)
{
    string nameCapt = Char.ToUpper(item[0]) + item.Substring(1);
    Console.WriteLine(nameCapt);
}

// Using for loop
for (int i = 0; i < names.Count; i++)
{
    string nameCapt = Char.ToUpper(names[i][0]) + names[i].Substring(1);
    Console.WriteLine(nameCapt);
}