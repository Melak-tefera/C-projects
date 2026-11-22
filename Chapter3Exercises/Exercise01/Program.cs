namespace Exercise01;

public class TestClass
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of the house: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the width of the house: ");
        double width = Convert.ToDouble(Console.ReadLine());

        House house = new House(length, width);
        house.ShowData();
    }
}
