namespace BankCli.Screens;

public static class DepositScreen
{
    public static void Screen()
    {
        decimal amount;
        string? amountString;
        do
        {
            Console.WriteLine("How much would you like to deposit");
            amountString = Console.ReadLine();
        }while(decimal.TryParse(amountString, out amount));

        Console.WriteLine($"Deposited {amount} successfully\nUpdated balance {{some_amount}}");
        HomeScreen.Screen();
    }
}