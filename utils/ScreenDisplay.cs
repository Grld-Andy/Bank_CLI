namespace BankCli.Utils;

public static class ScreenDisplay
{
    public static void ShowTitle(string title)
    {
        Console.Clear();
        Thread.Sleep(500);
        Console.WriteLine(title.ToUpper());
    }
}