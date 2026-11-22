namespace Exercise03;

public class Program3
{
    private int number1;
    private int number2;

    public Program3(int number1, int number2)
    {
        this.number1 = number1;
        this.number2 = number2;
    }

    public bool checkIf5()
    {
        return number1 == 5 || number2 == 5 ||
               number1 + number2 == 5 || Math.Abs(number1 - number2) == 5;
    }
}
