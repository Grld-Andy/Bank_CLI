using BankCli.Utils;

namespace BankCli.Screens;

public static class LoginScreen
{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("login");

        ReadInput.GetSafeString(out string? name, "Please enter your username");
        ReadInput.GetSafeString(out string? password, "Please enter your password");
        var isSuccess = AccountActions.LoginAccount(name!, password!);

        if (isSuccess)
        {
            Console.WriteLine($"Hi {name}, you have logged in successfully");
            Console.ReadLine();
            HomeScreen.Screen();
        }
        else
        {
            Console.WriteLine("Invalid name or password, please try again.");
            Console.ReadLine();
        }
    }
}