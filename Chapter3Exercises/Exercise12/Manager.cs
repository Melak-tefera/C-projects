namespace Exercise12;

public class Manager : Member
{
    public string Department { get; set; }

    public Manager(string name, int age, string phoneNumber, string address, decimal salary, string department)
        : base(name, age, phoneNumber, address, salary)
    {
        Department = department;
    }

    public override void DisplayInformation()
    {
        Console.WriteLine("MANAGER");
        base.DisplayInformation();
        Console.WriteLine($"Department: {Department}");
    }
}
