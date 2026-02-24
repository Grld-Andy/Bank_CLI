namespace BankCli.Screens;

public static class DepositScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("deposit");

        Account account = CurrentAccount.MyAccount!;
        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to deposit");

        AccountActions.Deposit(account.AccountName, amount);

        ScreenDisplay.ShowSuccess($"Deposited {amount} successfully\nUpdated balance {account.Balance}");
    }
}