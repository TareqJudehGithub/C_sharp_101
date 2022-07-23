// See https://aka.ms/new-console-template for more information
Console.WriteLine(" print each Order ID that starts with the letter B\n");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Your code here
string[] cleanOrderSteam = orderStream.Split(',');

foreach (string order in cleanOrderSteam)
{
    if (order.StartsWith("B")) Console.WriteLine(order);
}
