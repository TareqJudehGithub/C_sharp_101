// See https://aka.ms/new-console-template for more information

class StringManipulation
{

    static void Main(string[] args)
    {
        Console.WriteLine("String Manipulation\n");

        WorkingStrings();
    }

    static void WorkingStrings()
    {
        string firstName = "john";
        string lastName = "smith";
        DateTime myDate = DateTime.Now;


        // Concatenation
        string fullName = firstName + ' ' + lastName;

        // String Length
        int firstNameLength = firstName.Length;

        // Replace String parts
        string lastNameChange = lastName.Replace("th", "thy");

        // Append to other String variables - same as string concatenation
        string greet = "Hello" + " world";

        Console.WriteLine("");
        // Split String
        string[] splitName = fullName.Split(' ');
        foreach (string name in splitName) Console.WriteLine(name);
        for (int i = 0; i < splitName.Length; i++) Console.WriteLine(splitName[i]);
        Console.WriteLine("");

        // Compare Strings
        string nullString = null;
        string emptyString = string.Empty;  // "";
        string whiteSpaceString = " ";

        if (string.IsNullOrEmpty(nullString)) Console.WriteLine($"{nullString} is null");
        if (string.IsNullOrWhiteSpace(whiteSpaceString)) Console.WriteLine($"{whiteSpaceString} is a white space string");
        if (string.IsNullOrEmpty(emptyString)) Console.WriteLine($"{emptyString} is Empty");

        Console.WriteLine("");
        Console.Write("String comparison result: ");
        Console.WriteLine(string.Compare(firstName, firstName));
        /* 
          String.Compare()
         If result is -1, that means the two strings in comparison are not equal.
         If result is 0, that means the two strings in comparison are equal.
         */

        Console.Write("String comparison result: ");
        Console.WriteLine(firstName.Equals(lastName));

        /*
           String.Equals() 
            If result is False, that means the two strings in comparison are not equal.
            If result is True, that means the two strings in comparison are equal.
       */


        // Convert to String
        int randomNumber = 123456789;
        string stringNumber = randomNumber.ToString();
        Console.WriteLine($"String number: {stringNumber}");
        Console.WriteLine(stringNumber.GetType());


    }
}



