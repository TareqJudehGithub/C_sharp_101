// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Variables");

int points = 0;

System.Console.WriteLine("Harry was caught wandering the halls. -50 points for Gryffindor");
//update points here
points -= 50; // -50
System.Console.WriteLine(points);

System.Console.WriteLine("Harry was being cheeky in class. -3 points for Gryffindor");
//update points here
points -= 3;  // -53
System.Console.WriteLine(points);

System.Console.WriteLine("Hermione got full marks on Lockhart's quiz. 30 points for Gryffindor");
//update points here
points += 30;  // -23
System.Console.WriteLine(points);

System.Console.WriteLine("Ron won the underground chess game. 100 points for Gryffindor");
//update points here
points += 100;  // 77
System.Console.WriteLine(points);

System.Console.WriteLine("Harry defeated Quirrell. 60 points for Gryffindor");
//update points here
points += 60; // 137
System.Console.WriteLine(points);

//Print the variable
Console.WriteLine($"Gryffindor scored a total of {points}");



