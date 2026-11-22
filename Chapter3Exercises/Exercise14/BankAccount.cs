namespace Exercise14;

public abstract class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public string AccountNumber
    {
        get => accountNumber;
        set => accountNumber = value;
    }

    public decimal Balance
    {
        get => balance;
        protected set => balance = value;
    }

    protected BankAccount(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public abstract void deposit(decimal amount);
    public abstract bool withdraw(decimal amount);
}

