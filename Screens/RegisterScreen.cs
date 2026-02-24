namespace BankCli.Screens;

public static class RegisterScreen{
    public static void Screen()
    {
        string? name;
        do
        {
            System.Console.WriteLine("Please enter your username");
            name = Console.ReadLine();
        }while(!string.IsNullOrWhiteSpace(name));

        
        while(true){
            string? password;
            do
            {
                System.Console.WriteLine("Please enter a new password");
                password = Console.ReadLine();
            }while(!string.IsNullOrWhiteSpace(password));

            string? confirmPassword;
            do
            {
                System.Console.WriteLine("Please repeat password to confirm");
                confirmPassword = Console.ReadLine();
            }while(!string.IsNullOrWhiteSpace(confirmPassword));

            if (!string.IsNullOrWhiteSpace(password) && password.Equals(confirmPassword))
            {
                break;
            }
        }

        System.Console.WriteLine($"{name}, account created successfully");
    }
}