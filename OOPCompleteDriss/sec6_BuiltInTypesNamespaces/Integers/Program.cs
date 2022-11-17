namespace Integers;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Integers\n");
        // Side - in bytes
        Console.WriteLine($"sbyte is allocated {sizeof(sbyte)} bytes in memory");       // 1 byte
        Console.WriteLine($"byte is allocated {sizeof(byte)} bytes in memory");          // 1 byte
        Console.WriteLine($"short is allocated {sizeof(short)} bytes in memory");
        Console.WriteLine($"ushort is allocated {sizeof(ushort)} bytes in memory");
        Console.WriteLine($"int is allocated {sizeof(int)} bytes in memory");
        Console.WriteLine($"uint is allocated {sizeof(uint)} bytes in memory");
        Console.WriteLine($"long is allocated {sizeof(long)} bytes in memory");
        Console.WriteLine($"ulong is allocated {sizeof(ulong)} bytes in memory\n");


        // TryParase
        string stringNum = "1000";
        int number;

        bool isParsed = Int32.TryParse(stringNum, out number);
        Console.WriteLine($"{nameof(isParsed)} = {isParsed}");
        Console.WriteLine($"{nameof(number)} = {number.GetType()}");
    }
}
