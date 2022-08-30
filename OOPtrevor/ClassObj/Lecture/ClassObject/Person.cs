namespace ClassObject
{
    internal class Person
    {
        // fields
        private double _salary;

        // Properties
        internal string FirstName { get; set; } = string.Empty;
        internal string LastName { get; set; } = string.Empty;
        internal int Age { get; set; }

        internal void SetSalary(double value)
        {
            this._salary = value;
        }
        internal double GetSalary()
        {
            return this._salary;
        }
        internal int Year
        {
            get
            {
                return DateTime.Now.Year - Age;
            }
        }


        // Methods
        internal void DisplayInfo()
        {
            // Display info
            Console.WriteLine($"\nFirst Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}\nSalary: {GetSalary()}");
        }

        internal void YearOfBirth(string firstName)
        {
            Console.WriteLine($"{firstName} was born in {Year}");
        }
    }
}
