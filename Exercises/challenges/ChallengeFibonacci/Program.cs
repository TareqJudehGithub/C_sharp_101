// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fibonacci challenge\n");

List<int> fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    int preceeding1 = fibonacciNumbers[fibonacciNumbers.Count - 1];
    int preceeding2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    int fiboNum = preceeding1 + preceeding2;

    fibonacciNumbers.Add(fiboNum);
}
foreach (int fiboNum in fibonacciNumbers)
{
    Console.WriteLine(fiboNum);
}







