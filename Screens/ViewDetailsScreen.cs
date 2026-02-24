using BankCli.Models;
using BankCli.Utils;

namespace BankCli.Screens;

public static class ViewDetailsScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("your details");
        
        Account account = CurrentAccount.MyAccount!;
        Console.WriteLine($"Hello {account.AccountName}.\n Account ID: {account.Id}.\n Balance: {account.Balance}.\n Date Registered: {account.DateCreated.ToShortDateString()}");
        HomeScreen.Screen();
    }
}