using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount("AC1001", 5000);

            Console.WriteLine($"Account Number: {acc.AccountNumber}");
            Console.WriteLine($"Initial Balance: {acc.Balance}");

            acc.Deposit(2000);
            acc.Withdraw(1500);

            Console.WriteLine($"Remaining Balance: {acc.Balance}");
        }
    }
}
