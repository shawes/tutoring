public class SavingsAccount : BankAccount {

    public SavingsAccount(string number, string holderId) : 
          base(number, holderId) {
              InterestRate = 1;
          }
}
