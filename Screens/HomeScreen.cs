using BankCli.Utils;

namespace BankCli.Screens;

public static class HomeScreen
{
    public static void Screen()
    {
        Console.WriteLine($"Your current username {CurrentAccount.MyAccount?.AccountName}");
        ReadInput.GetSafeInt(out int choice, $"Welcome {CurrentAccount.MyAccount!.AccountName}, what would you like to do?\n Please enter a number\n\n1. Withdraw\n2. Deposit\n3. View Account Details\n4. Logout");

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
                Console.WriteLine("Sorry, please try again");
                break;
        }
        Screen();
    }
}