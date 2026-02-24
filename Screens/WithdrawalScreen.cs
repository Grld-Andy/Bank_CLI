namespace BankCli.Screens;

public static class WithdrawalScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("withdraw");
        
        Account account = CurrentAccount.MyAccount!;

        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to withdraw");

        if(amount > account.Balance)
        {
            ScreenDisplay.ShowError($"Transaction denied. Insufficient funds to withdraw {amount}\nYour Balance: {account.Balance}");
            return;
        }

        if(amount > 5000)
        {
            ReadInput.GetSafeInt(out int choice, "High-value withdrawal: Please proceed with caution\n1. Continue\n2. Cancel");
            if (choice != 1){
                ScreenDisplay.ShowSuccess("Transaction cancelled safely");
            }
            else
            {
                AccountActions.Withdraw(account.AccountName, amount);
                ScreenDisplay.ShowSuccess($"Withdrawal of {amount} completed successfully.\nYour updated balance is {account.Balance}");
            }
        }
        else
        {
            AccountActions.Withdraw(account.AccountName, amount);
            ScreenDisplay.ShowSuccess($"Withdrawal of {amount} completed successfully.\nYour updated balance is {account.Balance}");
        }
    }
}