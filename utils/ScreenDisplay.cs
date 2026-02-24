namespace BankCli.Utils;

public static class ScreenDisplay
{
    public static void ShowTitle(string title)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        // Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine(title.ToUpper());
        Console.ForegroundColor = ConsoleColor.White;
    }
}