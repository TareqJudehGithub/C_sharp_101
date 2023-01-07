namespace Enumerations;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enumerations\n");

        // Instantiate an enumeration 

        // option 1
        Planet neptune = Planet.Neptune;     // Enum varName = Enum.enumConstant

        // option 2
        Planet earth = (Planet)2;   // casting from int (num 2) to a Planet type.
        Planet satur = (Planet)5;

        // option 3 - new operator
        Planet venus = new Planet();
        venus = (Planet)1;
        Planet mercury = new Planet();  // Since Mercury is the default constant, its value is 0.

        SuperPowerLevel1 level1 = new SuperPowerLevel1();


        Console.WriteLine($"{nameof(neptune)} enum constant: {neptune}\n");

        Console.WriteLine($"{nameof(earth)} enum constant: {earth}");
        Console.WriteLine($"{nameof(satur)} enum constant: {satur}");

        Console.WriteLine($"{nameof(venus)} enum constant: {venus}");
        Console.WriteLine($"{nameof(mercury)} enum constant: {mercury}");           // 0 (default)
        Console.WriteLine($"{nameof(level1)} enum constant: {level1}");                 // None 


        // TryParse method        
        bool isParsedSuccess = Enum.TryParse(typeof(Planet), "10", out var planetMoon);

        if (isParsedSuccess)
        {
            Planet moon = (Planet)planetMoon;

            Console.WriteLine($"{nameof(moon)} enum constant: {moon}");
        }
        else
        {
            Console.WriteLine("Parse failed.");
        }

        // Initialize an enumeration with an integer value - use the ToObject method
        // Converts int value to a Planet (or to an enum value).
        Planet jupiter = (Planet)Enum.ToObject(typeof(Planet), 4);

        Console.WriteLine($"{nameof(jupiter)} enum constant: {jupiter}");
        // >>> $ jupiter enum constant: Jupiter

        Console.WriteLine("");
        // IsDefined method
        // Determines if an enumerations contains an int value.
        int[] valueToCheck = { -100, 0, 1, 3, 8, 200 };
        Planet planet;

        foreach (var value in valueToCheck)
        {
            if (Enum.IsDefined(typeof(Planet), value))
            {
                planet = (Planet)value;
                Console.WriteLine($"{value} exists in {typeof(Planet).Name} enum: {planet}");
            }
            else
            {
                Console.WriteLine($"{value} does not exist in {typeof(Planet).Name}");
            }
        }

        Console.WriteLine("");
        // GetValues method

        var values = Enum.GetValues(typeof(Planet));
        Console.WriteLine($"{typeof(Planet).Name} enum constants: ");
        foreach (var value in values)
        {
            Console.WriteLine($"Planet Name: {value} Value: {(int)value}");
        }

        Console.WriteLine(values.GetType());

    }
}

