namespace Exercise16;

public class Program
{
    public static void Main(string[] args)
    {
        Marks studentA = new A(80, 75, 90);
        Marks studentB = new B(85, 80, 90, 95);

        Console.WriteLine($"Student A percentage: {studentA.getPercentage():F2}%");
        Console.WriteLine($"Student B percentage: {studentB.getPercentage():F2}%");
    }
}
