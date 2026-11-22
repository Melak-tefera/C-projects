namespace Exercise15;

public class Programmer : Employee
{
    private double overTimeHour;
    private decimal hourlyRate;

    public double OverTimeHour { get => overTimeHour; set => overTimeHour = value; }
    public decimal HourlyRate { get => hourlyRate; set => hourlyRate = value; }

    public Programmer(string name, decimal baseSalary, double overTimeHour, decimal hourlyRate)
        : base(name, baseSalary)
    {
        OverTimeHour = overTimeHour;
        HourlyRate = hourlyRate;
    }

    public override decimal calculateSalary() => BaseSalary + ((decimal)OverTimeHour * HourlyRate);

    public override void displayInfo()
    {
        Console.WriteLine("PROGRAMMER");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base salary: {BaseSalary:C}");
        Console.WriteLine($"Overtime hours: {OverTimeHour}");
        Console.WriteLine($"Hourly rate: {HourlyRate:C}");
        Console.WriteLine($"Total salary: {calculateSalary():C}");
    }
}
