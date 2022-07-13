// See https://aka.ms/new-console-template for more information
using System.Globalization;
Console.WriteLine("Date Time Manipulation\n");

// Empty DateTime 
// Initialize a new object from DateTime class
DateTime date = new DateTime();


// Instantiate a new variable from dateTime class
DateTime dateOfBirth = new DateTime(1975, 6, 27);
Console.WriteLine($"I was born in {dateOfBirth}");

DateOnly dob = DateOnly.FromDateTime(dateOfBirth); // Date only
TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth); // Time only
Console.WriteLine($"I was born in {dob}");
Console.WriteLine($"I was born in {tob}");


// Create a DateTime from current time stamp
DateTime now = DateTime.Now;
Console.WriteLine($"The time now is {now}");


// Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine($"The date from string is {dateFromString}");

// Add additional time
Console.WriteLine($"One hour from now is: {now.AddHours(1)}");
Console.WriteLine($"One day from now is: {now.AddDays(1)}");

// Ticks from DateTime
Console.WriteLine("Time as numeral: " + now.Ticks);



Console.WriteLine("\nDate Time\n");

DateTime localDate = DateTime.Now;

Console.WriteLine($"The date now is {DateOnly.FromDateTime(localDate)}"); // Today's date
Console.WriteLine($"The date now is {TimeOnly.FromDateTime(localDate)}"); // Time's now
Console.WriteLine($"UTC time now is {localDate}"); // Both date and time



