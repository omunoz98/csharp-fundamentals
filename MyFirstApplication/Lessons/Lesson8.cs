namespace MyFirstApplication;

/*
 Constants and static
 */

internal class Lesson8
{
    // Constant variables
    public const int Months = 12; // Per year
    public const int Weeks = 52; // Per year
    public const int Days = 365; // Per year
    public const int Hours = 60; // Per day
 
    public const double DaysPerMonth = (double)Days / (double)Months;

    public static int DayCount;
    private int _days;

    public Lesson8(int calDays)
    {
        _days = calDays;
    }
    public static int CalculateDayCount()
    {
        return ++DayCount;
    }

    public void CalculateHours()
    {
        int total = Hours * _days;
        Console.WriteLine($"The total hours for {_days} days is {total}.");
        CalculateDayCount();
    }
    public void CalculateHoursV2()
    {
        Func<int, int> totalHours = static value => Hours * value;
        Console.WriteLine($"The total version2 hours for {_days} is"  +
            $"{totalHours(_days)}");
    }




} // class
