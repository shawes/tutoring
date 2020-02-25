using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBankAccount1 = new SavingsAccount("001","Hawes");
            myBankAccount1.Deposit(500);
            Console.WriteLine(myBankAccount1.AccountHolderId + " has $" + myBankAccount1.Balance);

            var myBankAccount2 = new CurrentAccount("002","Goh");
            myBankAccount2.Deposit(1500);
            Console.WriteLine(myBankAccount2.AccountHolderId + " has $" + myBankAccount2.Balance);
            myBankAccount2.Withdraw(115);
            Console.WriteLine(myBankAccount2.AccountHolderId + " now has $" + myBankAccount2.Balance);

            var myBankAccount3 = new OverDraftAccount("003","Lee");
            myBankAccount3.Deposit(150);
            Console.WriteLine(myBankAccount3.AccountHolderId + " has $" + myBankAccount3.Balance);
            myBankAccount3.Withdraw(755);
            Console.WriteLine(myBankAccount3.AccountHolderId + " now has $" + myBankAccount3.Balance);


            var myBranch = new BankBranch("POSB-Bedok", "Tan Chuan-Jin");
            
            myBranch.PrintCustomers();
            myBranch.AddAccount(myBankAccount1);
            myBranch.AddAccount(myBankAccount2);
            myBranch.AddAccount(myBankAccount3);
            myBranch.PrintCustomers();
            Console.WriteLine("Total deposits: $" + myBranch.TotalDeposits());
            Console.WriteLine("Total interest paid: $" + myBranch.TotalInterestPaid());
            Console.WriteLine("Total interest earned: $" + myBranch.TotalInterestEarned());
        }
    }
}
