public class BankAccount
{

    public BankAccount(string name, decimal initialBalance)
    {
        Owner = name;
        Balance = initialBalance;
        Number = string.Empty;
    }

    /// <summary>
    /// 10 digit number that uniquely identifies the account
    /// </summary>
    public string Number { get; }

    /// <summary>
    /// Name of the owner
    /// </summary>
    public string Owner { get; set; }

    /// <summary>
    /// Bank account balance
    /// </summary>
    public decimal Balance { get; }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
    }
}