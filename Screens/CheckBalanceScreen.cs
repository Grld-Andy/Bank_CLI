namespace BankCli.Screens;

public static class CheckBalanceScreen
{
    public static void Screen()
    {
        Console.WriteLine($"Your current balance is {{some_money}}");
        HomeScreen.Screen();
    }
}