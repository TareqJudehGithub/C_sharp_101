
namespace StringFomatting
{
    class RemoveReplace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove() and Replace()\n");

            names();
            NameCapitalized("hello world");

        }
        // Methods
        /**
         * This method extracts every word in a sentence and capitalizes it.
         */
        static void names()
        {
            string manyNames = "john william lion sarah adamn ali";
            string[] names = manyNames.Split(' ');
            string[] namesCapitalized = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string nameCap = Char.ToUpper(names[i][0]) + names[i].Substring(1);
                namesCapitalized[i] = nameCap;
            }
            foreach (string name in namesCapitalized) Console.WriteLine(name);
        }

        static string NameCapitalized(string name)
        {
            /* 
             This method, take a string as an input, capitalizes it's first letter and return the string capitalized.s
             */
            string employeeName = string.Empty;

            string[] names = name.Split(" ");
            string[] nameCapitalized = new string[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                string nameToCapitalize = Char.ToUpper(names[i][0]) + names[i].Substring(1);
                nameCapitalized[i] = nameToCapitalize;
            }
            employeeName = String.Join(" ", nameCapitalized);
            return employeeName;
        }

    }
}
