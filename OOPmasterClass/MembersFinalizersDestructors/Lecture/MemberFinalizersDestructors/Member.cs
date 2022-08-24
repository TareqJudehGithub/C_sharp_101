namespace MemberFinalizersDestructors
{
    internal class Member
    {

        // member - private fields
        private string memberName;
        private string jobTitle;
        private decimal salary;

        // member - public field
        public int age;

        // member - properties - 
        public string JobTitle
        {
            get
            {
                return this.jobTitle;
            }
            set
            {
                this.jobTitle = value;
            }
        }

        // Setters
        internal void SetMemberName(string value)
        {
            this.memberName = value;
        }
        internal void SetSalary(decimal value)
        {
            this.salary = value;
        }
        internal void SetAge(int value)
        {
            this.age = value;
        }

        // member - constructor

        internal Member()
        {

        }
        internal Member(string memberName, string jobTitle, int age)
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.age = age;
        }
        internal Member(string memberName, string jobTitle, int age, decimal salary)
        {
            this.memberName = memberName;
            this.jobTitle = jobTitle;
            this.age = age;
            this.salary = salary;
        }

        // Getters
        internal string GetMemberName()
        {
            return this.memberName;
        }
        internal decimal GetSalary()
        {
            return this.salary;
        }
        internal int GetAge()
        {
            return this.age;
        }


        // member - methods
        internal void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                Console.WriteLine($"Hi, my name is {GetMemberName}, My job title is {JobTitle}, and I'm {GetAge()} years old.");
                Console.WriteLine($"My salary is {GetSalary()}");
            }
            else
            {
                PrivateData();
            }
        }

        private void PrivateData()
        {
            Console.WriteLine($"Hi, my name is {GetMemberName}, My job title is {JobTitle}, and I'm {GetAge()} years old.");
        }

        // member - Finalizer/destructor
        ~Member()
        {
            // cleanup statement
            Console.WriteLine("Deconstruction of Members Object");
        }
    }
}
