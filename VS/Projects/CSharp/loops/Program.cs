// See https://aka.ms/new-console-template for more information
Console.WriteLine("Loops");

/* 
 while loop 
    - Whenever the condition is true, keep on repeating it.
    - 
 */
int counter = 10;

while (counter > 0)
{
    Console.WriteLine(counter);
    counter--;
    if (counter == 0)
    {
        Console.WriteLine("GO!\n");
    }
}

/* 
 for loop
 - for loop,hello iterates for a number of times we already know, unlike while-loops.
 */
string greet = "hello";
Console.WriteLine("for - loop");
for (int i = 0; i <= greet.Length; i++)
{
    Console.WriteLine($"{i} is still less than {greet.Length}");
    if (i == greet.Length)
    {
        Console.WriteLine($"{i} equals {greet.Length}");
    }
}

