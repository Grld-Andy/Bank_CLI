namespace BankCli.Utils;

public static class ReadInput
{
    public static void GetSafeInt(out int choice, string prompt)
    {
        string? choiceString;
        do
        {
            Console.WriteLine(prompt);
            choiceString = Console.ReadLine();
        }while(int.TryParse(choiceString, out choice));
    }

    public static void GetSafeString(out string? name, string propmt)
    {
        do
        {
            Console.WriteLine(propmt);
            name = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(name));
    }
}