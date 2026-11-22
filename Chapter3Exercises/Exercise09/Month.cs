namespace Exercise09;

public class Month
{
    private int monthNumber;

    public int MonthNumber
    {
        get { return monthNumber; }
        set { monthNumber = value; }
    }

    public Month(int monthNumber)
    {
        MonthNumber = monthNumber;
    }

    public string GetMonthName()
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };
        if (monthNumber < 1 || monthNumber > 12) return "Invalid month number";
        return months[monthNumber - 1];
    }

    public int GetNumberOfDays()
    {
        if (monthNumber < 1 || monthNumber > 12) return 0;
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        return days[monthNumber - 1];
    }

    public string DisplayDetail()
    {
        if (monthNumber < 1 || monthNumber > 12) return "Invalid month number. Please enter a number from 1 to 12.";
        return $"Month: {GetMonthName()}
Number of days: {GetNumberOfDays()}";
    }
}
