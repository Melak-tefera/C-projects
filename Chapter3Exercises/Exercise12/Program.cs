namespace Exercise12;

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee("Abebe", 25, "0911000000", "Addis Ababa", 12000m, "Software Development");
        Manager manager = new Manager("Meron", 35, "0922000000", "Adama", 20000m, "IT Department");

        employee.DisplayInformation();
        Console.WriteLine();
        manager.DisplayInformation();
    }
}
