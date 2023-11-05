/*
namespace Pildoras;

public static class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount("Manu", 1000);
        Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} $");
        
        account.MakeWithdrawal(120, DateTime.Now, "Hammock");
        Console.WriteLine(account.Balance);

        Console.WriteLine(account.GetAccountHistory());
        
        try
        {
            account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine("Exception caught trying to overdraw");
            Console.WriteLine(e.ToString());
        }
        
        try
        {
            var invalidAccount = new BankAccount("invalid", -55);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception caught creating account with negative balance");
            Console.WriteLine(e.ToString());
        }
        
        account.MakeWithdrawal(50, DateTime.Now, "Xbox game");
        Console.WriteLine(account.Balance);
        
    }
}
*/