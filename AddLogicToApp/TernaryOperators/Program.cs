// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ternary Operator");



/* 
  A ternary operator evaluates a Boolean expression, and returns the result of evaluating one of two expressions, depending on whether the Boolean expression evaluates to true or false.

 Here's the basic form:
<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

 Suppose you need to quickly determine if a customer's purchase is eligible for a promotional discount. If the amount of the sale is greater than 1000, then discount the purchase by 100 dollars. If the amount is 1000 or less, only discount the sale by 50 dollars.
 */

Console.WriteLine("Enter sales amount: ");
int saleAmount = Convert.ToInt32(Console.ReadLine());

int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"The discount amount is: ${discount}");

