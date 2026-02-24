using System.Runtime;
using BankCli.Models;
using BankCli.Utils;

namespace BankCli.Screens;

public static class WithdrawalScreen
{
    public static void Screen()
    {
        Account account = CurrentAccount.MyAccount!;

        ReadInput.GetSafeDecimal(out decimal amount, "How much would you like to withdraw");

        if(amount > account.Balance)
        {
            Console.WriteLine($"Sorry, you cannot withdraw {amount} due to insufficient amount in your account\nYour Balance: {account.Balance}");
            return;
        }

        if(amount > 5000)
        {
            ReadInput.GetSafeInt(out int choice, "High-value withdrawal: Please proceed with caution\n1. Continue\n2. Cancel");
            if (choice != 1){
                Console.WriteLine("Transaction cancelled safely");
            }
            else
            {
                Console.WriteLine($"Withdrew {amount} successfully\nUpdated balance {{some_amount}}");
            }
        }
        
        Console.WriteLine($"Withdrew {amount} successfully\nUpdated balance {{some_amount}}");
    }
}