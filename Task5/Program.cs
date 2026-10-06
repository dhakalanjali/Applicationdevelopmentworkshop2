namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        // Your birthdate (year, month, day). Change it to your own.
        DateTime birthDate = new DateTime(2004, 5, 15);

        // Current date and time from the computer's clock.
        DateTime currentDate = DateTime.Now;

        // Subtracting two DateTime values gives a TimeSpan.
        TimeSpan ageSpan = currentDate - birthDate;

        // TimeSpan has days, so divide by 365.25 to get years.
        int ageInYears = (int)(ageSpan.TotalDays / 365.25);

        Console.WriteLine($"Birthdate    : {birthDate:dd MMM yyyy}");
        Console.WriteLine($"Current date : {currentDate:dd MMM yyyy, HH:mm}");
        Console.WriteLine($"Age in years : {ageInYears}");

        // Add 10 days to the birthdate.
        DateTime birthPlus10 = birthDate.AddDays(10);
        Console.WriteLine($"Birthdate + 10 days: {birthPlus10:dd MMM yyyy}");
    }
}