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

    public static void ShowError(string value)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(value);
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }

    public static void ShowSuccess(string value)
    {
        
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(value);
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
}