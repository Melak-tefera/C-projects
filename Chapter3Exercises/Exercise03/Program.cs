namespace Exercise03;

public class TestProgram3
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Program3 test = new Program3(number1, number2);
        Console.WriteLine(test.checkIf5());
    }
}
