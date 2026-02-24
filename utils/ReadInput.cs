namespace BankCli.Utils;

public static class ReadInput
{
    public static int GetSafeInt(out int choice)
    {
        string? choiceString;
        do
        {
            Console.WriteLine("Welcome, what would you like to do?\n Please enter a number\n\n1. Create account\n2. Login to account\n3. Quit");
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));
        return choice;
    }
}