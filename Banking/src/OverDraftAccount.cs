public class OverDraftAccount : BankAccount {

    public double OverDraftInterestRate { get; set; }
    public OverDraftAccount(string number, string holderId) : 
          base(number, holderId) {
              InterestRate = 0.25;
              OverDraftInterestRate = 6.0;
          }
    
    public override bool Withdraw(double amount) {
        Balance -= amount;
        return true;
    }
    public override double CalculateInterest() {
        return Balance > 0 ? Balance * (InterestRate / 100) : Balance * (OverDraftInterestRate / 100);
    }
}
