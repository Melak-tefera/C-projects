using System;

namespace Exercise15;

public class Program
{
    public static void Main(string[] args)
    {
        Employee manager = new Manager("Abebe", 20000m, 5000m);
        Employee programmer = new Programmer("Meron", 15000m, 10, 250m);

        manager.displayInfo();
        Console.WriteLine();
        programmer.displayInfo();
    }
}
