namespace Exercise14;

public class SavingsAccount : BankAccount
{
    private decimal amount;

    public decimal Amount
    {
        get => amount;
        set => amount = value;
    }

    public SavingsAccount(string accountNumber, decimal balance, decimal amount)
        : base(accountNumber, balance)
    {
        Amount = amount;
    }

    public override void deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited: {amount:C}");
    }

    public override bool withdraw(decimal amount)
    {
        if (amount <= 0 || amount > Balance)
        {
            Console.WriteLine("Invalid amount or insufficient balance.");
            return false;
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawn: {amount:C}");
        return true;
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"Account number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance:C}");
        Console.WriteLine($"Amount field: {Amount:C}");
    }
}
