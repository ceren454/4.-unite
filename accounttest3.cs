using System;

class AccountTest
{
    static void Main()
    {
        var account1 = new Account("Jane Green");
        var account2 = new Account("John Blue");

        Console.WriteLine($"account1 name is: {account1.Name}");
        Console.WriteLine($"account2 name is: {account2.Name}");
    }
}
