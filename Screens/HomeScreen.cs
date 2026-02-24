namespace BankCli.Screens;

public static class HomeScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("home");
        
        ReadInput.GetSafeInt(out int choice, $"Welcome {CurrentAccount.MyAccount!.AccountName}, what would you like to do?\nPlease enter a number\n\n1. Withdraw\n2. Deposit\n3. View Account Details\n4. Logout");

        switch (choice)
        {
            case 1:
                WithdrawalScreen.Screen();
                break;
            case 2:
                DepositScreen.Screen();
                break;
            case 3:
                ViewDetailsScreen.Screen();
                break;
            case 4:
                CurrentAccount.LogoutAccount();
                return;
            default:
                ScreenDisplay.ShowError("Sorry, please try again");
                break;
        }
        Screen();
    }
}