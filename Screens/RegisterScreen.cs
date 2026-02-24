using BankCli.Utils;

namespace BankCli.Screens;

public static class RegisterScreen{
    public static void Screen()
    {
        ReadInput.GetSafeString(out string? name, "Please enter your username");
        
        while(true){
            ReadInput.GetSafeString(out string? password, "Please enter a new password");
            ReadInput.GetSafeString(out string? confirmPassword, "Please repeat password to confirm");

            if (!string.IsNullOrWhiteSpace(password) && password.Equals(confirmPassword))
            {
                break;
            }
        }

        Console.WriteLine($"{name}, account created successfully");
    }
}