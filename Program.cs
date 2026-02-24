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
        System.Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Create account\n2. Login to account\n3. Quit");
        int choice;
        string? choiceString;

        do
        {
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
        
    }

    // withdraw

    // deposit

    // check balance
}
