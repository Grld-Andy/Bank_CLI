using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
using BankCli.Models;

namespace BankCli.Utils;

public class AccountActions
{
    private static readonly string BankDatabasePath = "../Database/FileDb.csv";
    public static readonly List<Account> Accounts = [];


    private static Account GetAccount(string name)
    {
        var account = Accounts
            .FirstOrDefault(a => a.AccountName == name);
        return account!;
    }

    public static bool LoginAccount(string name, string password)
    {
        var account = Accounts
            .FirstOrDefault(a => a.AccountName == name && a.Password == password);
        
        if(account is null)
        {
            return false;
        }

        CurrentAccount.LoginAccount(account);
        return true;
    }

    public static void Withdraw(string name, decimal amount)
    {
        Account account = GetAccount(name);
        account.Balance -= amount;
        UpdateDatabase();
    }
    
    // file operations

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

    private static void UpdateDatabase()
    {
        using StreamWriter sr = new(BankDatabasePath);
        sr.WriteLine("Id, Name, Password, Balance, Date_Created");
        foreach(var account in Accounts)
        {
            sr.WriteLine($"{account.Id}, {account.AccountName}, {account.Password}, {account.Balance}, {account.DateCreated}");
        }
    }
}