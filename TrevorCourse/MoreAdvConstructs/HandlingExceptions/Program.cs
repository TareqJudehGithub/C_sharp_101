namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Handling Exceptions\n");

            /* 
             
            try - a try block attempts an operation
            catch - catch any fatal error of exception
            finally - whether any of the try or catch blocks were executed, execute the finally block of code.
            throw - interrupts the programs displaying the error occurring.
             */

            UserInfo();
        }

        static void UserInfo()
        {
            string firstName = string.Empty;
            string lastName = string.Empty; ;
            int age = 0;
            try
            {
                Console.Write("First Name: ");
                firstName = Console.ReadLine();

                Console.Write("Last Name: ");
                lastName = Console.ReadLine();

                Console.Write("Age: ");
                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"First Name: {firstName}\n" +
                $"Last Name: {lastName}\n" +
                $"Age: {age}\n");
            }
            catch (FormatException err)
            {
                Console.WriteLine($"\nError occurred!\nAge must be an Integer number\n{err.Message}\n");
            }
            finally
            {
                Console.WriteLine("End of program.");
            }


        }
    }
}