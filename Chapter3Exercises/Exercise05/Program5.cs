namespace Exercise05;

public class Program5
{
    private int number1;
    private int number2;
    private int number3;

    public Program5(int number1, int number2, int number3)
    {
        this.number1 = number1;
        this.number2 = number2;
        this.number3 = number3;
    }

    public bool checkIfPossible()
    {
        return number1 + number2 == number3 ||
               number1 + number3 == number2 ||
               number2 + number3 == number1;
    }
}
