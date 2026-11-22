namespace Exercise15;

public class Manager : Employee
{
    private decimal bonus;
    public decimal Bonus { get => bonus; set => bonus = value; }

    public Manager(string name, decimal baseSalary, decimal bonus)
        : base(name, baseSalary)
    {
        Bonus = bonus;
    }

    public override decimal calculateSalary() => BaseSalary + Bonus;

    public override void displayInfo()
    {
        Console.WriteLine("MANAGER");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Base salary: {BaseSalary:C}");
        Console.WriteLine($"Bonus: {Bonus:C}");
        Console.WriteLine($"Total salary: {calculateSalary():C}");
    }
}
