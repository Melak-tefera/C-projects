namespace Exercise13;

public class Program
{
    public static void Main(string[] args)
    {
        Shape rectangle = new Rectangle(10, 7);
        Shape triangle = new Triangle(10, 7);
        Shape circle = new Circle(5);

        Console.WriteLine($"Rectangle area: {rectangle.CalculateSurface():F2}");
        Console.WriteLine($"Triangle area: {triangle.CalculateSurface():F2}");
        Console.WriteLine($"Circle area: {circle.CalculateSurface():F2}");
    }
}
