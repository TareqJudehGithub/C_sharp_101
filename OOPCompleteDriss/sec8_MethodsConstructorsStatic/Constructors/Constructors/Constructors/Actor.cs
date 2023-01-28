namespace Constructors
{
    internal class Actor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Actor(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }

}
