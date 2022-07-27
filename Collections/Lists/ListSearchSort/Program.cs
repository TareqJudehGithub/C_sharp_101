namespace ListSearchSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists: Sort, Search, and Index\n");

            // methods called
            // FriendsList();
            FibonacciNumbers();

        }

        // Methods
        static void FriendsList()
        {
            /*
             * FriendsList() method explains List various functionalities.
             */
            List<string> friends = new List<string> { "Weird", "Scott", "Anna" };

            // Add elements to List
            friends.Add("Ali");
            friends.Add("Sarah");
            friends.Add("William");
            friends.Add("Khaled");
            friends.Add("Bilal");
            friends.Add("Peter");

            // Remove elements from List
            friends.Remove("Weird");
            friends.Remove("Anna");

            // Iterate through a list and  outputs it's elements
            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            Console.WriteLine("");

            // Searching elements in a List
            int nameIndex = 0;
            string name = string.Empty;
            do
            {
                Console.WriteLine("Enter friend's name, or press Enter to quit: ");

                name = Console.ReadLine();
                nameIndex = friends.IndexOf(name);

                if (nameIndex == -1 && !string.IsNullOrEmpty(name))
                {
                    Console.WriteLine($"\nName {name} was not found!");
                }
                else if (nameIndex != -1 && !string.IsNullOrEmpty(name))
                {
                    Console.WriteLine($"\nHi, {name}! Your index is at {nameIndex}");

                }

            }
            while (!string.IsNullOrEmpty(name));
            Console.WriteLine("Good bye!");
        }

        static void FibonacciNumbers()
        {
            List<int> fiboNumbers = new List<int> { 1, 1 };


            while (fiboNumbers.Count < 20)
            {
                int prevVal1 = fiboNumbers[fiboNumbers.Count - 1];  // last number in the list 
                int prevVal2 = fiboNumbers[fiboNumbers.Count - 2];  // the 2nd number from the end 
                Console.WriteLine($"last number:  {prevVal1}");
                Console.WriteLine($"number before: {prevVal2}");

                int nextVal = prevVal1 + prevVal2;
                Console.WriteLine($"{prevVal1} + {prevVal2} = {nextVal}");
                Console.WriteLine("");

                fiboNumbers.Add(nextVal);
            }

            foreach (int number in fiboNumbers) Console.Write($"{number}, ");
            {

            }
        }
    }
}