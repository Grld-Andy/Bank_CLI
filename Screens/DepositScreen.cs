using BankCli.Utils;

namespace BankCli.Screens;

public static class DepositScreen
{
    public static void Screen()
    {
        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to deposit");

        Console.WriteLine($"Deposited {amount} successfully\nUpdated balance {{some_amount}}");
        HomeScreen.Screen();
    }
}