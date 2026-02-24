using BankCli.Models;
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
                Account account = new()
                {
                    Id = Guid.NewGuid(),
                    AccountName = name!,
                    Password = password,
                    DateCreated = DateTime.Now,
                    Balance = 0.00M
                };

                var accountCreated = AccountActions.SaveNewAccount(account);
                
                if(accountCreated){
                    Console.WriteLine($"{name}, account created successfully");
                    HomeScreen.Screen();
                }
                else
                {
                    Console.WriteLine($"An account with the username: {name} already exists.\nPlease try again.");
                }
                break;
            }
            else
            {
                Console.WriteLine("Please enter matching passwords to proceed.");
            }
        }

    }
}