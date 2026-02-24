namespace BankCli;

public class Program
{
    public static void Main(string[] args)
    {
        Screen1();
    }

    // main interface
    public static void Screen1()
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
                Screen1();
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

        System.Console.WriteLine($"{name} Account Created Successfully");
    }

    // withdraw

    // deposit

    // check balance
}
