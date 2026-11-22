namespace Exercise16;

public class A : Marks
{
    private double mark1;
    private double mark2;
    private double mark3;

    public A(double mark1, double mark2, double mark3)
    {
        ValidateMarks(mark1, mark2, mark3);
        this.mark1 = mark1;
        this.mark2 = mark2;
        this.mark3 = mark3;
    }

    private static void ValidateMarks(params double[] marks)
    {
        if (marks.Any(mark => mark < 0 || mark > 100))
            throw new ArgumentException("Each mark must be between 0 and 100.");
    }

    public override double getPercentage() => (mark1 + mark2 + mark3) / 300.0 * 100;
}
