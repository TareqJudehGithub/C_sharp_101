// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");


//Ask for their first name.
Console.Write("What is your first name? ");
string firstName = Console.ReadLine();


//Ask for their last name.
Console.Write("What is your last name? ");
string lastName = Console.ReadLine();

//Ask: how old are you?
Console.Write("How old are you? ");
int age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(age);

// Ask them to make a username.
Console.Write("Enter a username: ");
string username = Console.ReadLine();

//Ask what city they live in.
Console.Write("City: ");
string city = Console.ReadLine();

//Ask what country that's from.
Console.Write("Country: ");
string country = Console.ReadLine();

Console.WriteLine($"Hello, {firstName} {lastName}!\nYou're {age} old!");
System.Console.WriteLine($"Your username is {username}.\nYou live in {city}, {country}");

