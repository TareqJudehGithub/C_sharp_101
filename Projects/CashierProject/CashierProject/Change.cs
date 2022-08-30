namespace CashierProject
{
    internal class Change
    {
        // member - fields
        private double _penny;
        private double _nickel;
        private double _dime;
        private double _quarter;
        private double _dollar;

        // member - properties
        internal double Penny
        {
            set { this._penny = value; }
            get { return this._penny; }
        }
        internal double Nickel
        {
            set { this._nickel = value; }
            get { return this._nickel; }
        }
        internal double Dime
        {
            set { this._dime = value; }
            get { return this._dime; }
        }
        internal double Quarter
        {
            set { this._quarter = value; }
            get { return this._quarter; }
        }
        internal double Dollar
        {
            set { this._dollar = value; }
            get { return this._dollar; }
        }

        // constructor
        internal Change()
        {
            Penny = 0.01;
            Nickel = 0.05;
            Dime = 0.1;
            Quarter = 0.25;
            Dollar = 1;
        }

        // methods
        internal void DisplayInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Penny(s): {Penny:C}");
            Console.WriteLine($"Nickel(s): {Nickel:C}");
            Console.WriteLine($"Dime(s): {Dime:C}");
            Console.WriteLine($"Quarter(s): {Quarter:C}");
            Console.WriteLine($"Dollar(s): {Dollar:C}");
            Console.WriteLine("");
        }

        internal void CalculateChange(double cashReceived, double totalOrder)
        {
            /*
             This method calculates customer's change amount.
             */

            int pennies = 0;
            int nickels = 0;
            int dimes = 0;
            int quarters = 0;
            int dollars = 0;

            double coins = cashReceived - totalOrder;
            double change = cashReceived - totalOrder;
            double changeReturned = 0;

            while (change >= Dollar)
            {
                changeReturned += Dollar;
                change -= Dollar;
                dollars++;
            }
            while (change >= Quarter)
            {
                changeReturned += Quarter;
                change -= Quarter;
                quarters++;
            }
            while (change >= Dime)
            {
                changeReturned += Dime;
                change -= Dime;
                dimes++;
            }
            while (change >= Nickel)
            {
                changeReturned += Nickel;
                change -= Nickel;
                nickels++;
            }
            while (change >= Penny)
            {
                changeReturned += Penny;
                change -= Penny;
                pennies++;
            }
            Thread.Sleep(1000);
            Console.Write($"Your change is: ");
            if (dollars > 0) Console.Write($"{dollars} dollars. ");
            if (quarters > 0) Console.Write($"{quarters} quarters. ");
            if (dimes > 0) Console.Write($"{dimes} dimes. ");
            if (nickels > 0) Console.Write($"{nickels} nickels. ");
            if (pennies > 0) Console.Write($"{pennies} pennies. ");

            Thread.Sleep(250);
            Console.WriteLine($"with a total of: {coins:C2}");
            Console.Write($"");

            Thread.Sleep(250);
            Console.WriteLine("Thank you and have a lovely day!");


        }
    }
}
