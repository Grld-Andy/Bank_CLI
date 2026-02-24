namespace BankCli.Models;

public class Account
{
    public Guid Id { get; set; }
    public string AccountName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime DateCreated { get; set; }
    public decimal Balance { get; set; }
}