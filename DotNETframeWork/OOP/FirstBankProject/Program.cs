using System;
using System.Threading;
class Program
{
    static int mainMenuChoice;
    static void Main()
    {
        // Declare variables
        string username = string.Empty;
        string password = null;

        // capture user inputs:
        do
        {
            // Display title 
            Console.WriteLine("My First Bank\n");
            Console.WriteLine("::Login Page::\n");

            Console.WriteLine("Please enter your username and password, or type exit to quit program.");
            Console.Write("Username: ");
            username = Console.ReadLine();
            if (username == "EXIT" || username == "exit")
            {
                Console.WriteLine("Good bye!\n");
                break;
            }
            if (string.IsNullOrEmpty(username))
            {
                Console.WriteLine("Username should not be empty.\n");
                Thread.Sleep(2000);
                Console.Clear();
                continue;
            }
            Console.Write("Password: ");
            password = Console.ReadLine();

            if ((username != "system" || password != "manager"))
            {
                Console.WriteLine("Invalid username or password!\n");
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
        while ((string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) || (username != "system" || password != "manager"));

        if (username == "system" && password == "manager")
        {
            Console.Clear();

            MainMenu();

            while (mainMenuChoice != 0)
            {
                Console.Clear();
                MainMenu();
            }
        }
    }

    // Methods
    static void MainMenu()
    {
        // Declare variable for storing user's menu choice
        bool isInteger = false;
        string choice = string.Empty;

        Console.WriteLine("");

        do
        {
            Console.WriteLine("TO DO: Main menu here.");
            Console.WriteLine("1. Customers");
            Console.WriteLine("2. Accounts");
            Console.WriteLine("3. Fund Transfer");
            Console.WriteLine("4. Fund Transfer Statement");
            Console.WriteLine("5. Account Statement");
            Console.WriteLine("0. to exit");

            Console.WriteLine("");

            Console.Write("Enter choice: ");
            string mainMenuChoiceStr = Console.ReadLine();
            isInteger = Int32.TryParse(mainMenuChoiceStr, out mainMenuChoice);

            switch (mainMenuChoice)
            {
                case 1: Customers(); break;
                case 2: Accounts(); break;
                case 3: choice = "Fund Transfer"; break;
                case 4: choice = "Fund Transfer Statement"; break;
                case 5: choice = "Account Statement"; break;
                case 0: choice = "Exit"; break;
                default: choice = "Invalid choice\n"; break;
            }

            if (mainMenuChoice == 0)
            {
                Console.Clear();
                Console.WriteLine("Good bye!");
                break;
            }
            else
            {
                Console.Clear();
            }
        }
        while (!isInteger || mainMenuChoice < 0 || mainMenuChoice > 5);
    }

    static void Customers()
    {
        int customersChoice = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("Customers Menu");
            Thread.Sleep(100);

            Console.WriteLine(@"
1. Add Customer
2. Update Customer Information
3. Delete Customer
4. View Customers
0. Back to Main Menu
");
            Console.Write("Select an option: ");
            customersChoice = Convert.ToInt32(Console.ReadLine());

            if (customersChoice == 0)
            {
                Console.Clear();
                Console.WriteLine("Returning to main menu..");
                Thread.Sleep(2000);
            }
        }
        while (customersChoice != 0);

    }

    static void Accounts()
    {
        int accountsChoice = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("Accounts Menu");
            Thread.Sleep(100);

            Console.WriteLine(@"
1. Add Account
2. Update Account Details
3. Delete Account
4. View Accounts
0. Back to Main Menu
");
            Console.Write("Select an option: ");
            accountsChoice = Convert.ToInt32(Console.ReadLine());

            if (accountsChoice == 0)
            {
                Console.Clear();
                Console.WriteLine("Returning to main menu..");
                Thread.Sleep(2000);
            }
        }
        while (accountsChoice != 0);
    }

    static void FundTransfer()
    {

    }

    static void FundTransferStatement()
    {

    }
    static void AccountStatement()
    {

    }


}



/* 
  Console.WriteLine("1. Customers");
                Console.WriteLine("2. Accounts");
                Console.WriteLine("3. Fund Transfer");
                Console.WriteLine("4. Fund Transfer Statement");
                Console.WriteLine("5. Account Statement"); 
 
*/