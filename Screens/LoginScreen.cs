using BankCli.Utils;

namespace BankCli.Screens;

public static class LoginScreen
{
    public static void Screen()
    {
        ReadInput.GetSafeString(out string? name, "Please enter your username");
        ReadInput.GetSafeString(out string? password, "Please enter your password");

        Console.WriteLine($"{name} logged in successfully");
        HomeScreen.Screen();
    }
}