using System;

public class BankAccount
{
    public string AccountHolder { get; set; }
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative.");
            balance = value;
        }
    }

    public BankAccount(string accountHolder, decimal initialBalance)
    {
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient balance.");
        Balance -= amount;
    }
}

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount("John Doe", 1000);
        account.Deposit(500);
        Console.WriteLine($"Balance after deposit: {account.Balance}");

        try
        {
            account.Withdraw(2000); // Should trigger an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine($"Final Balance: {account.Balance}");
    }
}
