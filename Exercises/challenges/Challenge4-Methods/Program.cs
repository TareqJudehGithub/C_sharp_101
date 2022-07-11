// See https://aka.ms/new-console-template for more information
Console.WriteLine("Challenge - Methods\n");

// My friends
string john = "John Smith";
string bob = "Bob Hawkins";
string sarah = "Sarah Adams";


/*
 * This method greets accepts a friend string as a parameter, and greet it.
 * @param: friendName
 */
void greetFriend(string friendName)
{
    Console.WriteLine($"Hi, {friendName} my friend!");
}

greetFriend(john);
greetFriend(bob);
greetFriend(sarah);



