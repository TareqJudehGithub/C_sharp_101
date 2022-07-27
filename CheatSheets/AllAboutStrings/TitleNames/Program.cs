namespace TitleNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convert full names to title\n");

            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            convertToTitle(firstName, lastName);
        }

        static void convertToTitle(string firstName, string lastName)
        {
            /*
             * This method takes lowercase inputs, and return them capitalized.
             */

            string fullName = $"{firstName} {lastName}";
            int emptyStringIndex = fullName.IndexOf(" ");

            string firstNameCapt = Char.ToUpper(fullName[0]) + fullName.Substring(1, emptyStringIndex - 1);
            string lastNameCapt = Char.ToUpper(fullName[emptyStringIndex + 1]) + fullName.Substring(emptyStringIndex + 2);

            Console.WriteLine(firstNameCapt + " " + lastNameCapt);

        }



    }
}