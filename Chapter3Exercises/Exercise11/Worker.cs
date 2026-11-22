namespace Exercise11;

public class Worker : Human
{
    public decimal Wage { get; set; }
    public double HoursWorked { get; set; }

    public Worker(string firstName, string lastName, decimal wage, double hoursWorked)
        : base(firstName, lastName)
    {
        Wage = wage;
        HoursWorked = hoursWorked;
    }

    public decimal CalculateHourlyWage()
    {
        if (HoursWorked <= 0)
            throw new InvalidOperationException("Hours worked must be greater than zero.");
        return Wage / (decimal)HoursWorked;
    }
}
