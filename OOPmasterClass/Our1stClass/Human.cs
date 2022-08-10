namespace Our1stClass
{
    class Human
    {
        // member variables
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        // constructor
        internal Human(string humanFirst, string humanLast, string eyeColor, int age)
        {
            this.firstName = humanFirst;
            this.lastName = humanLast;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        // member methods (actions)
        public void IntroduceMySelf()
        {
            string firstNameToCapitalize = Char.ToUpper(firstName[0]) + firstName.Substring(1);
            string lastNameToCapitalize = Char.ToUpper(lastName[0]) + lastName.Substring(1);
            Console.WriteLine(@"Hi, I'm {0} {1}!
I have {2} eyes, and I'm {3} years old!
", firstNameToCapitalize, lastNameToCapitalize, eyeColor, age);
        }
    }
}
