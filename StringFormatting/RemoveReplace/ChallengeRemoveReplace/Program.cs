// See https://aka.ms/new-console-template for more information
Console.WriteLine("Challenge\n");
/* 
 This program extracts strings "5000" saving it in a quantity variable,
 */

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here


// save the "5000" string in quantity variable
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openSpanIndex = input.IndexOf(openSpan);
int closeSpanIndex = input.IndexOf(closeSpan);

openSpanIndex += openSpan.Length;
int length = closeSpanIndex - openSpanIndex;

string content = input.Substring(openSpanIndex, length);

quantity = content;


// Remove div HTML elements and replace word "trade" with "reg"
string tempOutput = input;
const string openingDiv = "<div>";
const string closingDiv = "</div>";

int openingDivIndex = input.IndexOf(openingDiv);
int closingDivIndex = input.IndexOf(closingDiv);

tempOutput = tempOutput.Remove(closingDivIndex);
tempOutput = tempOutput.Remove(openingDivIndex, openingDiv.Length);
tempOutput = tempOutput.Replace("trade", "reg");

output = tempOutput;

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");

