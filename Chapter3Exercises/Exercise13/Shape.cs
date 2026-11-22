namespace Exercise13;

public abstract class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    protected Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public abstract double CalculateSurface();
}
