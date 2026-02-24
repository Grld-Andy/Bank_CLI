namespace BankCli.Screens;

public static class LoginScreen
{
    public static void Screen()
    {
        string? name;
        do
        {
            Console.WriteLine("Please enter your username");
            name = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(name));

        
        string? password;
        do
        {
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(password));

        Console.WriteLine($"{name} logged in successfully");
    }
}