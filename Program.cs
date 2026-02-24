namespace BankCli;

public class Program
{
    public static void Main(string[] args)
    {
        MainScreen();
    }

    // main interface
    public static void MainScreen()
    {
        int choice;
        string? choiceString;
        do
        {
            System.Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Create account\n2. Login to account\n3. Quit");
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));

        switch (choice)
        {
            case 1:
                System.Console.WriteLine("hello");
                break;
            default:
                System.Console.WriteLine("Sorry, please try again");
                MainScreen();
                break;
        }
    }

    // create account
    public static void CreateAccountScreen()
    {
        string? name;
        do
        {
            System.Console.WriteLine("Please enter your username");
            name = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(name));

        
        while(true){
            string? password;
            do
            {
                System.Console.WriteLine("Please enter a new password");
                password = Console.ReadLine();
            }while(!string.IsNullOrWhiteSpace(password));

            string? confirmPassword;
            do
            {
                System.Console.WriteLine("Please repeat password to confirm");
                confirmPassword = Console.ReadLine();
            }while(!string.IsNullOrWhiteSpace(confirmPassword));

            if (!string.IsNullOrWhiteSpace(password) && password.Equals(confirmPassword))
            {
                break;
            }
        }

        System.Console.WriteLine($"{name}, account created successfully");
    }

    // login screen
    public static void LoginScreen()
    {
        string? name;
        do
        {
            System.Console.WriteLine("Please enter your username");
            name = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(name));

        
        string? password;
        do
        {
            System.Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(password));

        System.Console.WriteLine($"{name} logged in successfully");
    }

    // home screen
    public static void HomeScreen()
    {
        int choice;
        string? choiceString;
        do
        {
            System.Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Withdraw\n2. Deposit\n3. View Balance\n4. Logout");
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));

        switch (choice)
        {
            case 1:
                WithdrawalScreen();
                break;
            case 2:
                DepositScreen();
                break;
            case 3:
                MainScreen();
                break;
            default:
                System.Console.WriteLine("Sorry, please try again");
                HomeScreen();
                break;
        }
    }

    // withdraw
    public static void WithdrawalScreen()
    {
        decimal amount;
        string? amountString;
        do
        {
            System.Console.WriteLine("How much would you like to withdraw");
            amountString = Console.ReadLine();
        }while(decimal.TryParse(amountString, out amount));

        if(amount > 5000)
        {
            System.Console.WriteLine("High-value withdrawal: Please proceed with caution\n1. Continue\n2. Cancel");
            string? choiceString;
            int choice;
            do
            {
                System.Console.WriteLine("How much would you like to withdraw");
                choiceString = Console.ReadLine();
            }while(int.TryParse(choiceString, out choice));

            if (choice != 1){
                System.Console.WriteLine("Transaction cancelled safely");
            }

            System.Console.WriteLine($"Withdrew {amount} successfully\nUpdated balance {{some_amount}}");
        }

        HomeScreen();
    }

    // deposit
    public static void DepositScreen()
    {
        decimal amount;
        string? amountString;
        do
        {
            System.Console.WriteLine("How much would you like to deposit");
            amountString = Console.ReadLine();
        }while(decimal.TryParse(amountString, out amount));

        System.Console.WriteLine($"Deposited {amount} successfully\nUpdated balance {{some_amount}}");
        HomeScreen();
    }

    // check balance
}
