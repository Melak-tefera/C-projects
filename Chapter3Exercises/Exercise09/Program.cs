namespace Exercise09;

public class TestMonth
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a month number (1-12): ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            Month month = new Month(number);
            Console.WriteLine(month.DisplayDetail());
        }
        else
        {
            Console.WriteLine("Invalid entry. Please enter a whole number.");
        }
    }
}
