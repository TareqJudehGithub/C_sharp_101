namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Char\n");

            char char1 = 'C';
            char char2 = '\x0043';
            char char3 = '\u0043';
            char char4 = (char)67;

            Console.WriteLine($"{nameof(char1)} = {nameof(char2)} ? {char1 == char2}");
            Console.WriteLine($"{nameof(char2)} = {nameof(char3)} ? {char2 == char3}");
            Console.WriteLine($"{nameof(char3)} = {nameof(char4)} ? {char3 == char4}");

            // isLetter method
            Console.WriteLine($"{nameof(char1)} is it a char? {char.IsLetter(char1)}");

            // Convert char to string
            // 1 - using ToString() method from the char variable it self
            string Cletter = char1.ToString();
            // 2 - using ToStrting() method from the Char class
            string Cletter2 = char.ToString(char1);

            // string Concat method, add to string together (like + operator does).
            string combinedStrings = String.Concat("A, B, ", Cletter);
            Console.WriteLine(combinedStrings);


            //TryParse method

            string dLetter = "D";
            char d;

            bool isParsed = char.TryParse(dLetter, out d);

            Console.WriteLine($"Parse successful? {isParsed} {nameof(d)} = {d}");


            List<char> letters = new List<char>() { 'A', 'B' };
            Console.WriteLine(letters.Count());

            string letterC = "C";

            bool isCparsed = char.TryParse(letterC, out char c);

            if (isCparsed)
            {
                Console.WriteLine("$Parsing string {letterC} was successful!");
                letters.Add(c);

                foreach (char letter in letters)
                {
                    Console.WriteLine($"Letter: {letter}");
                }
            }
            else
            {
                Console.WriteLine("$Parsing string {letterC} failed!");
            }
        }
    }
}