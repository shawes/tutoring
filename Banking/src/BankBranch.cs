
using System;
using System.Linq;
using System.Collections.Generic;

public class BankBranch {
    public string BranchName { get; set; }
    public string BranchManager { get; set; }

    public List<BankAccount> BranchAccounts { get; set; }

    public BankBranch(string name, string manager) {
        this.BranchName = name;
        this.BranchManager = manager;
        this.BranchAccounts = new List<BankAccount>();
    }

    public void AddAccount(BankAccount account) {
        BranchAccounts.Add(account);
    }

    public void PrintCustomers() {
        if(BranchAccounts.Count > 0) {
            BranchAccounts.ForEach(x => Console.WriteLine(x.AccountHolderId));
        } else {
            Console.WriteLine("We do not have any customers. Uh oh.");
        }
    }

    public double TotalDeposits() {
        return BranchAccounts.Sum(x => x.Balance);
    }

    public double TotalInterestPaid() {
        return BranchAccounts.Sum(x => x.Balance > 0 ? x.CalculateInterest() : 0);
    }

    public double TotalInterestEarned() {
        return BranchAccounts.Sum(x => x.Balance < 0 ? -x.CalculateInterest() : 0);
    }

}
