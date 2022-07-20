// See https://aka.ms/new-console-template for more information
Console.WriteLine("SKU Challenge");


string SKU = "03-AA-M";

string[] product = SKU.Split('-');

string type = "";
string color = "";
string size = "";


switch (product[0])
{
    case "01":
        type = "sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Marron";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");
