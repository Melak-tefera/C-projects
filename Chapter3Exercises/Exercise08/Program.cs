namespace Exercise08;

public class TestProgram8
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Program8 test = new Program8(number1, number2);
        Console.WriteLine(test.checkNearest());
    }
}
