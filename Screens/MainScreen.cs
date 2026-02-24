namespace BankCli.Screens;

public static class MainScreen
{
    public static void Screen()
    {
        int choice;
        string? choiceString;
        do
        {
            Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Create account\n2. Login to account\n3. Quit");
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));

        switch (choice)
        {
            case 1:
                Console.WriteLine("hello");
                break;
            default:
                Console.WriteLine("Sorry, please try again");
                Screen();
                break;
        }
    }
}