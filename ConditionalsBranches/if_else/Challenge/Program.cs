// See https://aka.ms/new-console-template for more information

/* 
Challenge
 display a renewal message when a user signs in to the software system
 and is notified that their subscription will soon end.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

// If the user's subscription has expired
if (daysUntilExpiration == 0) {
  Console.WriteLine("Your subscription has expired.");
}
// If the user's subscription will expire in 1 day
else if (daysUntilExpiration == 1) {
  Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
}
// If the user's subscription will expire in 5 days or less:
else if (daysUntilExpiration <= 5) {
  Console.WriteLine($@"Your subscription expires in {daysUntilExpiration} days.
Renew now and save 10%!");
}
// If the user's subscription will expire in 10 days or less:
else if (daysUntilExpiration <= 10) {
  Console.WriteLine($"Your subscription will expire soon. Renew now!");
}
// If the user's subscription doesn't expire in 10 days or less
else {
  Console.WriteLine("Have a lovely day!");
}

Console.WriteLine(daysUntilExpiration);

