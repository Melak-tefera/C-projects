namespace Exercise08;

public class Program8
{
    private int number1;
    private int number2;

    public Program8(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
    }

    public int checkNearest()
    {
        if (number1 == number2) return 0;

        int distance1 = Math.Abs(100 - number1);
        int distance2 = Math.Abs(100 - number2);

        if (distance1 == distance2) return 0;
        return distance1 < distance2 ? number1 : number2;
    }
}
