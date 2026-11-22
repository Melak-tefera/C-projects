namespace Exercise12;

public class Member
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }

    public Member(string name, int age, string phoneNumber, string address, decimal salary)
    {
        Name = name;
        Age = age;
        PhoneNumber = phoneNumber;
        Address = address;
        Salary = salary;
    }

    public void PrintSalary()
    {
        Console.WriteLine($"Salary: {Salary:C}");
    }

    public virtual void DisplayInformation()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Phone number: {PhoneNumber}");
        Console.WriteLine($"Address: {Address}");
        PrintSalary();
    }
}
