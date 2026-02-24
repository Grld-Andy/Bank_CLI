using BankCli.Utils;

namespace BankCli.Screens;

public static class LoginScreen
{
    public static void Screen()
    {
        ReadInput.GetSafeString(out string? name, "Please enter your username");
        ReadInput.GetSafeString(out string? password, "Please enter your password");
        var isSuccess = AccountActions.LoginAccount(name!, password!);

        System.Console.WriteLine("done");

        if (isSuccess)
        {
            Console.WriteLine($"Hi {name}, you have logged in successfully");
            HomeScreen.Screen();
        }
        else
        {
            Console.WriteLine("Invalid name or password, please try again.");
        }
    }
}