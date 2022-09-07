namespace BirthdayCalculator.Models;

public class Repository
{
    private static List<BirthDate> birthDates = new List<BirthDate>();

    public static IEnumerable<BirthDate> BirthDates => birthDates;

    public static void addBirthDate(BirthDate birthDate)
    {
        birthDates.Add(birthDate);
    }
}