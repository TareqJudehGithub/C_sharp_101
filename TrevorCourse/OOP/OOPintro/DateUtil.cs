namespace OOPintro;

internal static class DateUtil
{

    // Methods
    internal static int YearOfBirth(int age)
    {
        DateTime dateNow = DateTime.Now;
        int yearOfBirth = dateNow.Year - age;
        return yearOfBirth;
    }
    internal static int Age(DateTime dateOfBirth)
    {
        DateTime dateToday = DateTime.Now;
        int DobYear = dateOfBirth.Year;
        int age = dateToday.Year - DobYear;
        return age;
    }
}
