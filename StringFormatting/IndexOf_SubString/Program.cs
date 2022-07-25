//See https://aka.ms/new-console-template for more information
//Console.WriteLine("IndexOf() and SubString()\n");

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closingSpan = "</span>";

int openingSpanIndex = message.IndexOf(openSpan);
int closingSpanIndex = message.IndexOf(closingSpan);

openingSpanIndex += openSpan.Length;
int length = closingSpanIndex - openingSpanIndex;

string spanContent = message.Substring(openingSpanIndex, length);
Console.WriteLine(spanContent);


// *********************************************************************

Console.WriteLine("");

string message2 = "Find what is (inside the parentheses)";

int startingIndex = message2.IndexOf('(');
int endingIndex = message2.IndexOf(')');

startingIndex += 1;
int stringsLength = endingIndex - startingIndex;

string result = message2.Substring(startingIndex, stringsLength);
Console.WriteLine(result);


Console.WriteLine("");
// *********************************************************************

// LastIndexOf()
string message3 = "(What if) I am (only interested) in the last (set of parentheses)?";
const char openParantheses = '(';
const char closingParentheses = ')';

int openParanIndex1 = message3.LastIndexOf(openParantheses);
int closeParanIndex1 = message3.LastIndexOf(closingParentheses);

openParanIndex1 += openParantheses.ToString().Length;
int stringsLength2 = closeParanIndex1 - openParanIndex1;

string result2 = message3.Substring(openParanIndex1, stringsLength2);
Console.WriteLine(result2);


// *********************************************************************

Console.WriteLine("");


/* This program outputs every text between parentheses */
string message4 = "(What if) there are (more than) one (set of parentheses)?";



const char openParan = '(';
const char closeParan = ')';

while (true)
{
    string openParanStr = openParan.ToString();

    int openParanLength = openParanStr.Length;

    int openParanIndex = message4.IndexOf(openParan);
    int closeParanIndex = message4.IndexOf(closeParan);


    if (openParanIndex == -1) break;

    openParanIndex += openParanLength;

    int length4 = closeParanIndex - openParanIndex;

    string result4 = message4.Substring(openParanIndex, length4);
    Console.WriteLine(result4);

    message4 = message4.Substring(closeParanIndex + 1); // update message removing found parentheses

}


// *********************************************************************
Console.WriteLine("Symbols exercise\n");

string message5 = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

char[] openSymbols = { '[', '{', '(' };
int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now we must find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "]":
            matchingSymbol = ']';
            break;
        case "}":
            matchingSymbol = '}';
            break;
        case ")":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message5.IndexOf(matchingSymbol, openingPosition);

    int length5 = closingPosition - openingPosition;

    string result5 = message5.Substring(openingPosition, length5);
    Console.WriteLine(result5);
}



