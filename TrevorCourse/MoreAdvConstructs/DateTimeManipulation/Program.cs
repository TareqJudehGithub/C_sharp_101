using System.Globalization;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {


            Console.WriteLine("DateTime class manipulation\n");


            // empty DateTime  - initialize a new DateTime object();
            DateTime date = new DateTime();

            // create a DateTime from date and time
            DateTime birthday = new DateTime(year: 1975, month: 6, day: 27);
            Console.WriteLine($"my birthday is in: {birthday}");

            // create a DateTime from current timestamps
            DateTime now = DateTime.Now;
            Console.WriteLine($"Today's date: {now}");

            // Today's date in string format - Very useful for users date entry:
            DateTime stringDate = DateTime.Parse("10/9/2022", CultureInfo.InvariantCulture);
            Console.WriteLine($"Date in string format: {stringDate}");

            //Console.WriteLine($"The time now is: {now.ToShortDateString()}");
            // create a DateTime from a string

            // add additional time - like an hour from now
            now.AddHours(1);
            Console.WriteLine($"An hour from now, the time is: {now.AddDays(1).AddHours(1)}");

            // DateTime from ticks - New Feature in C# 10
            Console.WriteLine($"Time as numeral is: {now.Ticks}");

            // date only - New feature in C#
            DateOnly MyBirthday = DateOnly.FromDateTime(birthday);
            Console.WriteLine($"Today's date only: {MyBirthday}");

            Console.WriteLine($"Today's date only: {birthday.ToShortDateString()}");
            Console.WriteLine($"Today's date only: {now.ToShortDateString()}");

            //time only
            Console.WriteLine($"Time now is: {now.ToShortTimeString()}");

            TimeOnly timeNow = TimeOnly.FromDateTime(now);
            Console.WriteLine($"Time now is: {timeNow}");

            //SslClientHelloInfo world
        }
    }
}