namespace OOPdotnetCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP\n");

            var account1 = new BankAccount("Kendra", 10000);
            var account2 = new BankAccount("Scott", 5500.545m);

            // Instantiate new obj off class BankAccount
            Console.WriteLine($"Account Number: {account1.Number}\nAccount Name: {account1.Owner}\nBalance: {account1.Balance:C}\n");


            // Testing errors
            // account1.MakeDeposit(-300, DateTime.Now, "Negative Money test");
            //account1.MakeWithdrawal(50000, DateTime.Now, "Testing withdrawing more than Balance.");

            try
            {
                // Transactions: deposit and withdrawal
                account1.MakeWithdrawal(1456.99M, DateTime.Now, "Buy new hammock");
                account1.MakeWithdrawal(500M, DateTime.Now, "Buy new Xbox"); // buy Xbox

                //var account3 = new BankAccount("Hacker", -1000M);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.ToString());

            }
            Console.WriteLine($"Account History:\n{account1.GetAccountHistory()}");
            Console.WriteLine($"New balance: {account1.Balance:C}");
        }
    }
}
