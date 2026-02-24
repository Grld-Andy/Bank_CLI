namespace BankCli.Screens;

public static class RegisterScreen{
    public static void Screen()
    {
        ScreenDisplay.ShowTitle("register");
        
        ReadInput.GetSafeString(out string? name, "Please enter your username");
        
        while(true){
            ReadInput.GetSafeString(out string? password, "Please enter a new password");
            ReadInput.GetSafeString(out string? confirmPassword, "Please repeat password to confirm");

            if (!string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(confirmPassword) && password.Equals(confirmPassword))
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
                    ScreenDisplay.ShowSuccess($"{name}, account created successfully. Press enter to continue.");
                    HomeScreen.Screen();
                }
                else
                {
                    ScreenDisplay.ShowError($"An account with the username: {name} already exists.\nPlease try again.");
                }
                break;
            }
            else
            {
                ScreenDisplay.ShowError("\nPlease enter matching passwords to proceed.");
            }
        }
    }
}