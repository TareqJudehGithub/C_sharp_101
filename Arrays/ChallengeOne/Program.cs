// See https://aka.ms/new-console-template for more information
Console.WriteLine("Challenge 1: Reverse words in a sentence\n");

/* This program reverses string text inside a sentence text */


string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(" ");
string[] revWords = new string[words.Length];  // new empty array

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);

    revWords[i] = new String(letters);
}

string result = String.Join(" ", revWords);
Console.WriteLine(result);
