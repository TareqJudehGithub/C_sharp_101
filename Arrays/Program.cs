// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arrays\n");

string[] pallets = { "B14", "A11", "B12", "A13" };

// sorting arrays
Console.WriteLine("Sorting..");
Array.Sort(pallets);
foreach (string pallet in pallets) Console.Write(pallet + ", ");
Console.WriteLine("\n");

// reverse arrays
Console.WriteLine("Reversing..");
Array.Reverse(pallets);
foreach (string pallet in pallets) Console.Write(pallet + ", ");
Console.WriteLine("\n");
Console.WriteLine(pallets.Length);


// clearing an element
Array.Clear(pallets, 0, 2); // removing the first and second elements
foreach (string pallet in pallets) Console.Write(pallet + ", ");
Console.WriteLine("\n");
Console.WriteLine(pallets.Length);


Console.WriteLine(pallets[0]);
if (pallets[0] != null) Console.WriteLine($"Before: {pallets[0].ToLower()}");
else Console.WriteLine("Element is null\n");

// resize arrays
Array.Resize(ref pallets, 6);
Console.WriteLine($"Length of arrays = {pallets.Length}");
foreach (string ele in pallets)
{
    Console.WriteLine($"Element: {ele}");
}