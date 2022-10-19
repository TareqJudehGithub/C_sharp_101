namespace OOPintro
{
    internal class Person
    {
        // Fields - private
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private int _age;
        private double _salary;
        private DateTime _birthday;

        // Properties (getters and setters) - public
        internal string FirstName
        {
            set { this._firstName = value; }
            get { return this._firstName; }
        }
        internal string LastName
        {
            set { this._lastName = value; }
            get { return this._lastName; }
        }
        internal int Age
        {
            set { this._age = value; }
            get { return this._age; }
        }
        // set a salary value
        internal void SetSalary(double value)
        { this._salary = value; }
        internal double GetSalary()
        {
            return this._salary;
        }
        internal void SetBirthday(DateTime value)
        {
            this._birthday = value;
        }
        internal DateTime GetBirthday()
        {
            return this._birthday;
        }
        internal bool IsEmployed { get; set; }

        // Constructor


        // Methods

        internal void EmployeeDetails()
        {
            Console.WriteLine($"Name: {NameCapitalized(FirstName)} {NameCapitalized(LastName)}\n" +
                $"Age: {CalculateAge(GetBirthday().Year)}\n" +
                $"Employment Status: {IsEmployed}");
            if (IsEmployed) Console.WriteLine($"Salary: {GetSalary():C2}");
            Console.WriteLine($"Birthday: {GetBirthday().Year}\n");
        }

        private string NameCapitalized(string employeeName)
        {
            /* 
             This method, take a string as an input, capitalizes it's first letter and return the string capitalized.s
             */
            string[] names = employeeName.Split(" ");
            string[] nameCapitalized = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string nameToCapitalize = Char.ToUpper(names[i][0]) + names[i].Substring(1);
                nameCapitalized[i] = nameToCapitalize;
            }
            employeeName = String.Join(" ", nameCapitalized);
            return employeeName;
        }

        private int CalculateAge(int birthdayYear)
        {
            DateTime dateToday = DateTime.Now;
            int year = dateToday.Year;

            int age = year - birthdayYear;
            Console.WriteLine($"Current Year: {year}");

            return age;
        }
        /* This method calculates Employees age*/
    }
}
