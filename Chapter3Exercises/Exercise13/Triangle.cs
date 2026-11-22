namespace Exercise13;

public class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height) { }
    public override double CalculateSurface() => Width * Height / 2;
}
