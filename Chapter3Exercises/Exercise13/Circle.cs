namespace Exercise13;

public class Circle : Shape
{
    public Circle(double radius) : base(radius, radius) { }
    public override double CalculateSurface() => Math.PI * Width * Height;
}
