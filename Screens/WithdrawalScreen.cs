namespace BankCli.Screens;

public static class WithdrawalScreen
{
    public static void Screen()
    {
        decimal amount;
        string? amountString;
        do
        {
            Console.WriteLine("How much would you like to withdraw");
            amountString = Console.ReadLine();
        }while(decimal.TryParse(amountString, out amount));

        if(amount > 5000)
        {
            Console.WriteLine("High-value withdrawal: Please proceed with caution\n1. Continue\n2. Cancel");
            string? choiceString;
            int choice;
            do
            {
                Console.WriteLine("How much would you like to withdraw");
                choiceString = Console.ReadLine();
            }while(int.TryParse(choiceString, out choice));

            if (choice != 1){
                Console.WriteLine("Transaction cancelled safely");
            }

            Console.WriteLine($"Withdrew {amount} successfully\nUpdated balance {{some_amount}}");
        }

        HomeScreen.Screen();
    }
}