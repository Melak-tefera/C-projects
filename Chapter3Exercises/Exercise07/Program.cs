namespace Exercise07;

public class TestProgram7
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Program7 rectangle = new Program7();
        rectangle.setLength(length);
        rectangle.setWidth(width);

        Console.WriteLine("******************************");
        Console.WriteLine($"The length of the rectangle is: {rectangle.getLength():G}");
        Console.WriteLine($"The width of the rectangle is: {rectangle.getWidth():G}");
        Console.WriteLine($"The area of the rectangle is: {rectangle.caculateArea():G}");
    }
}
