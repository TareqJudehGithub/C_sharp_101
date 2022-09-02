namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("foreach loop\n");


            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Call methods
            GreetFriend();
        }

        internal static void GreetFriend()
        {
            string friendName = string.Empty;
            string[] friendsList = new string[5];
            int counter = 0;

            while (counter < friendsList.Length)
            {
                Console.Write("Enter a new friend name, or  'quit' to finish: ");
                friendName = Console.ReadLine()!;

                if (friendName.Equals("quit")) break;

                friendsList[counter] = friendName;
                counter++;
            }

            foreach (string friend in friendsList)
            {
                if (string.IsNullOrEmpty(friend))
                    Console.WriteLine("Hello, Stranger!");
                else Console.WriteLine($"Hello, {friend}!");
            }
        }
    }
}

