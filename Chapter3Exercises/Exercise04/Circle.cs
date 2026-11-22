namespace Exercise04;

public class Circle
{
    private double radius;
    private string color;

    public Circle()
    {
        radius = 1.0;
        color = "red";
    }

    public Circle(double radius)
    {
        this.radius = radius;
        color = "red";
    }

    public double getPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public double getArea()
    {
        return Math.PI * radius * radius;
    }

    public string getColor()
    {
        return color;
    }
}
