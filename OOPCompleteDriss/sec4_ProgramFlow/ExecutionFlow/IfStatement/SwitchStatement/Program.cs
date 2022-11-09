namespace SwitchStatement;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Switch Statement\n");
        bool randomBool = GetBool();


        switch (randomBool)
        {
            case true:
                Console.WriteLine($"Boolean status: {randomBool}");
                Console.WriteLine("The boolean is TRUE!");
                break;
            case false:
                Console.WriteLine($"Boolean status: {randomBool}");
                Console.WriteLine("The boolean is FALSE!");
                break;
            default:
                Console.WriteLine("The return value is not a boolean.");
                break;
        }
        Console.WriteLine();

    }
    // Methods
    static internal bool GetBool()
    {
        // This method returns a random boolean
        Random random = new Random();
        bool randomBool = Convert.ToBoolean(random.Next(0, 2));

        return randomBool;

    }
}
