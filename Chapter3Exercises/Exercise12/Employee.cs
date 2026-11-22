namespace Exercise12;

public class Employee : Member
{
    public string Specialization { get; set; }

    public Employee(string name, int age, string phoneNumber, string address, decimal salary, string specialization)
        : base(name, age, phoneNumber, address, salary)
    {
        Specialization = specialization;
    }

    public override void DisplayInformation()
    {
        Console.WriteLine("EMPLOYEE");
        base.DisplayInformation();
        Console.WriteLine($"Specialization: {Specialization}");
    }
}
