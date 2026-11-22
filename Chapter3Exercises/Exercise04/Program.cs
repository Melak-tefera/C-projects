namespace Exercise04;

public class TestCircle
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle();
        Circle circle2 = new Circle(5.0);

        Console.WriteLine("Default circle:");
        Console.WriteLine($"Color: {circle1.getColor()}");
        Console.WriteLine($"Area: {circle1.getArea():F2}");
        Console.WriteLine($"Perimeter: {circle1.getPerimeter():F2}");

        Console.WriteLine("\nCircle with radius 5:");
        Console.WriteLine($"Area: {circle2.getArea():F2}");
        Console.WriteLine($"Perimeter: {circle2.getPerimeter():F2}");
    }
}
