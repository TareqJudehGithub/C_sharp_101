
namespace StringFomatting
{
    class RemoveReplace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove() and Replace()\n");

            names();

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
    }
}
