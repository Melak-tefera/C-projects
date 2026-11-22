namespace Exercise14;

public class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount account = new SavingsAccount("100200300", 5000m, 500m);
        account.DisplayAccount();
        account.deposit(1500m);
        account.withdraw(2000m);
        account.DisplayAccount();
    }
}
