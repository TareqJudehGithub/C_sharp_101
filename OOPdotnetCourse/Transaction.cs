namespace OOPdotnetCourse
{
    internal class Transaction
    {
        // properties
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        // constructor
        public Transaction(decimal amount, DateTime date, string notes)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = notes;
        }
    }
}
