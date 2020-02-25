using System;

public class BankAccount {

    public BankAccount(string number, string holderId) {
        this.AccountNumber = number;
        this.AccountHolderId = holderId;
    }

    public string AccountNumber { get; set; }

    public string AccountHolderId { get; set; }

    public double Balance { get; set; }
    
    public double InterestRate { get; protected set; }

    public virtual bool Withdraw(double amount) {
        if(Balance - amount > 0) {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public void Deposit(double amount) {
        Balance += amount;
    }

    public bool TransferTo(double amount, BankAccount toAccount) {
        bool canWithdraw = this.Withdraw(amount);
        if(canWithdraw) {
            toAccount.Deposit(amount);
            return true;
        }
        return false;
    }

    public virtual double CalculateInterest() {
        return Balance > 0 ? Balance * (InterestRate / 100) : 0;
    }

    public void CreditInterest(double interest) {
        Deposit(interest);
    }

}