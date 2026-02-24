namespace BankCli.Utils;

public static class ReadInput
{
    public static void GetSafeInt(out int result, string prompt)
    {
        string? resultString;
        do
        {
            Console.WriteLine(prompt);
            resultString = Console.ReadLine();
        }while(!int.TryParse(resultString, out result));
    }

    public static void GetSafeDecimal(out decimal result, string prompt)
    {
        string? resultString;
        do
        {
            Console.WriteLine(prompt);
            resultString = Console.ReadLine();
        }while(!decimal.TryParse(resultString, out result));
    }

    public static void GetSafeString(out string? result, string propmt)
    {
        do
        {
            Console.WriteLine(propmt);
            result = Console.ReadLine();
        }while(string.IsNullOrWhiteSpace(result));
    }
}