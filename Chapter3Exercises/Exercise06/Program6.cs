namespace Exercise06;

public class Program6
{
    private int number1;
    private int number2;
    private int number3;

    public Program6(int number1, int number2, int number3)
    {
        if (number1 < 0 || number2 < 0 || number3 < 0)
            throw new ArgumentException("All numbers must be non-negative.");

        this.number1 = number1;
        this.number2 = number2;
        this.number3 = number3;
    }

    public bool checkRigtmostDigit()
    {
        int digit1 = number1 % 10;
        int digit2 = number2 % 10;
        int digit3 = number3 % 10;

        return digit1 == digit2 || digit1 == digit3 || digit2 == digit3;
    }
}
