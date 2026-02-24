using BankCli.Models;
using BankCli.Utils;

namespace BankCli.Screens;

public static class DepositScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("deposit");

        Account account = CurrentAccount.MyAccount!;
        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to deposit");

        AccountActions.Deposit(account.AccountName, amount);

        Console.WriteLine($"Deposited {amount} successfully\nUpdated balance {account.Balance}");
        HomeScreen.Screen();
    }
}