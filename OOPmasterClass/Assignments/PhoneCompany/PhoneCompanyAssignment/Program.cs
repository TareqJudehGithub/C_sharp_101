namespace PhoneCompanyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate new objects
            Phone samsung = new Phone(company: "samsung", model: "A51", releaseDay: "2019");
            Phone nokia = new Phone(company: "nokia", model: "el dam3ah");
            Phone iphone = new Phone();

            // Call methods
            samsung.PhoneDetails();
            nokia.PhoneDetails();
            iphone.PhoneDetails();


        }
    }
}