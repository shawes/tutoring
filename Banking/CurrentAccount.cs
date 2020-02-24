public class CurrentAccount : BankAccount {
    
    public CurrentAccount(string number, string holderId) : 
          base(number, holderId) {
              InterestRate = 0.25;
          }
}
