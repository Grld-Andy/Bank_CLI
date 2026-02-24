using BankCli.Screens;
using BankCli.Utils;

namespace BankCli;

public class Program
{
    public static void Main(string[] args)
    {
        AccountActions.LoadAccounts();
        MainScreen.Screen();
    }
}
