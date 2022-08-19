namespace Our1stClass
{
    class Human
    {
        // member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;


        //  constructor (default parameter-less)
        public Human()
        {
            Console.WriteLine("Parameter-less constructor.");
        }

        // constructor (parameterized)
        internal Human(string humanFirst, string humanLast, string eyeColor, int age)
        {
            this.firstName = humanFirst;
            this.lastName = humanLast;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        internal Human(string humanFirst, string humanLast, string eyeColor)
        {
            this.firstName = humanFirst;
            this.lastName = humanLast;
            this.eyeColor = eyeColor;
        }

        internal Human(string humanFirst)
        {
            this.firstName = humanFirst;
        }
        internal Human(string humanFirst, string humanLast)
        {
            this.firstName = humanFirst;
            this.lastName = humanLast;

        }

        // member methods (actions)
        internal void IntroduceMySelf()
        {
            string firstNameToCapitalize;
            string lastNameToCapitalize;
            if (firstName != null && lastName != null)
            {
                firstNameToCapitalize = Char.ToUpper(firstName[0]) + firstName.Substring(1);
                lastNameToCapitalize = Char.ToUpper(lastName[0]) + lastName.Substring(1);


                if (firstName != null && lastName != null && eyeColor != null && age != 0)
                {
                    Console.WriteLine(@"Hi, I'm {0} {1}!
                I have {2} eyes, and I'm {3} years old!
                ", firstNameToCapitalize, lastNameToCapitalize, eyeColor, age);
                }
                else if (firstName != null && lastName != null && eyeColor != null)
                {
                    Console.WriteLine(@"Hi, I'm {0} {1}!
                I have {2} eyes.
                ", firstNameToCapitalize, lastNameToCapitalize, eyeColor);
                }
                else if (firstName != null && lastName != null)
                {
                    Console.WriteLine(@"Hi, I'm {0} {1}!", firstNameToCapitalize, lastNameToCapitalize);
                }
                else
                {
                    Console.WriteLine($"Hi, I'm {firstName}");
                }
            }

        }

        // Setters
        //internal void SetFirstName(string value)
        //{
        //    firstName = value;
        //}

        // Getters
        //internal string GetFirstName()
        //{
        //    return firstName;
        //}
    }
}
