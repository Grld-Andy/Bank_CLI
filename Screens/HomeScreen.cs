namespace BankCli.Screens;

public static class HomeScreen
{
    public static void Screen()
    {
        int choice;
        string? choiceString;
        do
        {
            Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Withdraw\n2. Deposit\n3. View Balance\n4. Logout");
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));

        switch (choice)
        {
            case 1:
                WithdrawalScreen.Screen();
                break;
            case 2:
                DepositScreen.Screen();
                break;
            case 3:
                MainScreen.Screen();
                break;
            default:
                Console.WriteLine("Sorry, please try again");
                Screen();
                break;
        }
    }
}