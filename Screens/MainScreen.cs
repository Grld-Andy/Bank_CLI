using BankCli.Utils;

namespace BankCli.Screens;

public static class MainScreen
{
    public static void Screen()
    {
        ReadInput.GetSafeInt(out int choice);

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
                Screen();
                break;
        }
    }
}