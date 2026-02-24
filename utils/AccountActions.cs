using BankCli.Models;

namespace BankCli.Utils;

public static class AccountActions
{
    private static readonly string BankDatabasePath = "../Database/FileDb.csv";

    public static void SaveNewAccount(Account account)
    {
        File.AppendAllText(BankDatabasePath, $"{account.Id}, {account.AccountName}, {account.Password}, {account.Balance}, {account.DateCreated}");
    }
}