namespace Exercise11;

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Abebe", "Kebede", 87.5);
        Worker worker = new Worker("Meron", "Alemu", 6000m, 160);

        Console.WriteLine($"Student: {student.FirstName} {student.LastName}, Mark: {student.Mark}");
        Console.WriteLine($"Worker: {worker.FirstName} {worker.LastName}");
        Console.WriteLine($"Wage: {worker.Wage:C}");
        Console.WriteLine($"Hours worked: {worker.HoursWorked}");
        Console.WriteLine($"Hourly wage: {worker.CalculateHourlyWage():C}");
    }
}
