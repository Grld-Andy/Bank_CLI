using BankCli.Models;

namespace BankCli.Utils;

public static class AccountActions
{
    private static readonly string BankDatabasePath = "../Database/FileDb.csv";
    public static readonly List<Account> Accounts = [];

    public static bool SaveNewAccount(Account account)
    {
        var user = Accounts.FirstOrDefault(a => a.AccountName == account.AccountName);
        if(user is not null)
        {
            return false;
        }

        File.AppendAllText(BankDatabasePath, $"{account.Id}, {account.AccountName}, {account.Password}, {account.Balance}, {account.DateCreated}");
        Accounts.Add(account);
        return true;
    }

    public static void LoadAccounts()
    {
        CreateDbIfNotExists();

        using StreamReader sr = new(BankDatabasePath);
        while(sr.Peek() >= 0)
        {
            string? line = sr.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                continue;
            }
            var splits = line.Split(", ");

            Account account = new()
            {
                Id = Guid.Parse(splits[0]),
                AccountName = splits[1],
                Password = splits[2],
                Balance = decimal.Parse(splits[3]),
                DateCreated = DateTime.Parse(splits[4])
            };

            Accounts.Add(account);
        }
    }

    private static void CreateDbIfNotExists()
    {
        if (!File.Exists(BankDatabasePath))
        {
            var fileInfo = new FileInfo(BankDatabasePath);
            fileInfo.Create().Close();
        }
    }
}