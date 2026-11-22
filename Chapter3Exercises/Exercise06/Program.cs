namespace Exercise06;

public class TestProgram6
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        try
        {
            Program6 test = new Program6(number1, number2, number3);
            Console.WriteLine(test.checkRigtmostDigit());
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
