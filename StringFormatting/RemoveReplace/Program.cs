
namespace StringFomatting
{
    class RemoveReplace
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove() and Replace()\n");


            //names()
            //removeString();
            replaceString();

        }

        // Methods

        static void removeString()
        {
            /**
             * This method explains string helper method Remove()
             */
            string data = "12345John Smith          5000  3  ";

            // Remove "John Smith"
            string cleanData = data.Remove(5, 16);
            Console.WriteLine(cleanData);
        }


        static void replaceString()
        {
            /*
             * * This method explains string helper method Replace()
             */
            string message = "This--is--ex-amp-le--da-ta";

            // replace "--" with " " 

            message = message.Replace("--", " ");
            message = message.Replace("-", "");


            Console.WriteLine(message);

        }

        static void names()
        {
            /**
             * This method extracts every word in a sentence and capitalizes it.
             */
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
