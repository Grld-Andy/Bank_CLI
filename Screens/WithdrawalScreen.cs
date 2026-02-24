using System.Runtime;
using BankCli.Utils;

namespace BankCli.Screens;

public static class WithdrawalScreen
{
    public static void Screen()
    {
        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to withdraw");

        if(amount > 5000)
        {
            ReadInput.GetSafeInt(out int choice, "High-value withdrawal: Please proceed with caution\n1. Continue\n2. Cancel");

            if (choice != 1){
                Console.WriteLine("Transaction cancelled safely");
            }
        }

        Console.WriteLine($"Withdrew {amount} successfully\nUpdated balance {{some_amount}}");
        HomeScreen.Screen();
    }
}