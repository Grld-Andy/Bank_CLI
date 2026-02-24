using BankCli.Models;

namespace BankCli.Utils;

public static class CurrentAccount
{
    public static Account? MyAccount { get; private set; } = null;

    public static void LoginAccount(Account account)
    {
        MyAccount = account;
    }

    public static void LogoutAccount()
    {
        MyAccount = null;
    }

    public static void Withdraw(decimal amount)
    {
        MyAccount?.Balance -= amount;
    }

    public static void Deposit(decimal amount)
    {
        MyAccount?.Balance += amount;
    }
    
}