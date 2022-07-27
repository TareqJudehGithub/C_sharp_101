using System.Text;

namespace OOPdotnetCourse
{
    internal class BankAccount
    {
        // properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in AllTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }

        }

        private static int accountNumberSeed = 1234567890; // This information should remain private
        private List<Transaction> AllTransactions = new List<Transaction>();  // Declaring an empy list 

        // constructor 
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");

        }


        // methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }
            var deposit = new Transaction(amount, date, note);
            AllTransactions.Add(deposit);
        }
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            AllTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            // String Builder
            var report = new StringBuilder();
            report.AppendLine("Date\tAmount\tNote"); // header

            foreach (var transaction in AllTransactions)
            {
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t${transaction.Amount}\t\t{transaction.Notes}"); // rows
            }
            return report.ToString();
        }

    }
}
