namespace InheritanceChallenge2
{
    internal class Employee
    // This is the base class
    {
        // fields
        private static int currentID;

        // properties
        internal int ID { get; set; }

        internal string FirstName { get; set; }
        internal string LastName { get; set; }
        internal string Position { get; set; }
        internal double Salary { get; set; }

        public Employee()
        {
            ID = CurrentID();
        }
        // Methods

        internal int CurrentID()
        {
            /**
             * This method increments ID by 1 and return it
             @return currentID +1
             */
            currentID++;
            return currentID;
        }
        public string Work()
        {
            return "Employee is active.";
        }
        public string Pause()
        {
            return "Employee is not active.";
        }
        public override string ToString()
        {
            return $"ID: {ID}\n" +
                $"First name: {CapitalizeString(FirstName)}\n" +
                $"Last name: {LastName}\n" +
                $"Position: {Position}" +
                $"Salary: {Salary}\n";
        }

        public string CapitalizeString(string userEntry)
        {
            string name = String.Empty;
            string[] strings = userEntry.Split();
            string[] capitalizeStr = new string[strings.Length];

            for (int i = 0; i < strings.Length; i++)
            {
                capitalizeStr[i] = Char.ToUpper(strings[i][0]) + strings[i].Substring(1);
                name += String.Join(" ", capitalizeStr[i]);
            }
            return name;
        }
    }
}
