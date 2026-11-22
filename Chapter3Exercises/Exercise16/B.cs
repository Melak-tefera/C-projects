namespace Exercise16;

public class B : Marks
{
    private double mark1;
    private double mark2;
    private double mark3;
    private double mark4;

    public B(double mark1, double mark2, double mark3, double mark4)
    {
        if (new[] { mark1, mark2, mark3, mark4 }.Any(mark => mark < 0 || mark > 100))
            throw new ArgumentException("Each mark must be between 0 and 100.");
        this.mark1 = mark1;
        this.mark2 = mark2;
        this.mark3 = mark3;
        this.mark4 = mark4;
    }

    public override double getPercentage() => (mark1 + mark2 + mark3 + mark4) / 400.0 * 100;
}
