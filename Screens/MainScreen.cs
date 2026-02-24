using BankCli.Utils;

namespace BankCli.Screens;

public static class MainScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("welcome");

        ReadInput.GetSafeInt(out int choice, "What would you like to do?\nPlease enter a number\n1. Create account\n2. Login to account\n3. Quit");

        switch (choice)
        {
            case 1:
                RegisterScreen.Screen();
                break;
            case 2:
                LoginScreen.Screen();
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Sorry, please try again");
                break;
        }
        
        Screen();
    }
}