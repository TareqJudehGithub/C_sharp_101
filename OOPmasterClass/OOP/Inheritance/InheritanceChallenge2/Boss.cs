namespace InheritanceChallenge2
{
    internal class Boss : Employee
    {
        // properties
        internal string CompanyCar;

        // constructor
        internal Boss(string firstName, string lastName, string position, double salary, string car)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
            CompanyCar = car;
        }
        // methods

        internal string Lead()
        {
            return $"{FirstName} {LastName} is leading the company";
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"First name: {CapitalizeString(FirstName)}\n" +
                $"Last name: {CapitalizeString(LastName)}\n" +
                $"Position: {CapitalizeString(Position)}" +
                $"Salary: {Salary}\n" +
                $"Car: {CompanyCar.ToUpper()}";
        }
    }
}
