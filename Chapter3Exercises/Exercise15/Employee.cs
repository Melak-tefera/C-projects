namespace Exercise15;

public abstract class Employee
{
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }

    protected Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract decimal calculateSalary();
    public abstract void displayInfo();
}
