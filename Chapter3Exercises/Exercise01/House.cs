namespace Exercise01;

public class House
{
    public double Length { get; private set; }
    public double Width { get; private set; }
    public double Area { get; private set; }

    public House(double length, double width)
    {
        Length = length;
        Width = width;
        Area = length * width;
    }

    public void ShowData()
    {
        Console.WriteLine($"I am a house, my area is {Area:F2} m2");
    }
}
