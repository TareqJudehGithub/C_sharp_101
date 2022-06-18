// See https://aka.ms/new-console-template for more information
Console.WriteLine("Combine branches and loops");

// find the sum of all integers 1 through 20 that are divisible by 3.
int sum = 0;

for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        Console.WriteLine($"{i} is divisible by 3. {i} / 3 = {i / 3}");
        sum += i;
        Console.WriteLine($"sum = {sum}\n");
    }
}
Console.WriteLine($"sum total = {sum}");


