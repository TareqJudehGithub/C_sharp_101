namespace Properties
{
    internal class Employee
    {
        // fields - instance
        private int _empID;
        private string _empName;
        private string _empJob;
        private double _salary;
        private double _tax;

        // fields - static
        private static string _companyName;

        // properties
        internal int EmpID
        {
            set
            {
                if (value >= 100) this._empID = value;
            }
            get
            {
                return this._empID;
            }
        }
        internal string EmpName
        {
            set
            {
                this._empName = value;
            }
            get
            {
                return this._empName;
            }
        }
        internal string EmpJob
        {
            set
            {
                this._empJob = value;
            }
            get
            {
                return this._empJob;
            }
        }

        internal static string CompanyName
        {
            set
            {
                if (value.Length <= 20) _companyName = value;
            }
            get
            {
                return _companyName;
            }
        }

        // read-only properties
        internal double Salary
        {
            get
            {
                return this._salary;
            }
        }

        // write-only property
        internal double Tax
        {
            set
            {
                if (value >= 10 && value <= 20) this._tax = value;
            }
        }

        // Auto-Implemented Properties
        internal string NativePlace { get; set; } = "Amman"; // property default value (changeable).


        // constructors
        internal Employee()
        {

        }
        internal Employee(int id, string name, string job, double salary, double tax)
        {
            this._empID = id;
            this._empName = name;
            this._empJob = job;
            _companyName = "Hi-Tech Company";
            this._salary = salary;
            this._tax = tax;

        }

        // methods

        internal void EmployeeInfo()
        {
            System.Console.WriteLine("Employee Information:");
            System.Console.WriteLine($"ID: {EmpID}\nName: {EmpName}\nJob: {EmpJob}\nCompany: {CompanyName}\nSalary: {Salary}\nTown: {NativePlace}");
        }

        internal double CalculateNetSalary()
        {
            double taxAmount = Salary - this._tax;
            return taxAmount;
        }
    }

}
