// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array and string methods\n");

// reverse string values

string greet = "dlrow olleh";

Console.Write("String before reverse: ");
Console.WriteLine(greet);

char[] greetArr = greet.ToCharArray();
Array.Reverse(greetArr);
string revGreet = new string(greetArr);

// Capitalize every first char in the string
int emptyStrIndex = revGreet.IndexOf(" ");
string firstWord = Char.ToUpper(revGreet[0]) + revGreet.Substring(1, emptyStrIndex);
string secondWord = Char.ToUpper(revGreet[emptyStrIndex + 1]) + revGreet.Substring(emptyStrIndex + 2);

revGreet = firstWord + "" + secondWord;
Console.Write("String after reverse: ");
Console.WriteLine(revGreet);

// join characters inside greetArr array into a string
string joinWords = String.Join("", greetArr);
Console.WriteLine(joinWords); // $  h, e, l, l, o,  , w, o, r, l, d

Console.WriteLine("");

// split joined value string into an array of string

string[] letters = joinWords.Split(" "); // split and create a new line on each empty string.
foreach (string letter in letters)
{
    Console.WriteLine(letter);
}





