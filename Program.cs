using System;

namespace TutoringExamples
{
   class Program
    {
        //these arrays is visible in all the static method, 
        //so you can use them in your method implementation

        static int[] minIncomes = new int[] 
            { 20000, 30000, 40000, 80000, 
              120000, 160000, 200000, 320000 };
        static double[] taxRates = new double[] 
            { 0.02, 0.035, 0.07, 0.115, 
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmounts = new int[] 
            { 0, 200, 550, 3350, 
              7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome() {
            Console.Write("Please enter your annual taxable income: ");
            string income = Console.ReadLine(); // input will always return a string
            return Convert.ToInt32(income); // income cannot exceed 2.1 billion
        }

        static int GetTaxBracket(int income) {
            if(income < minIncomes[0]) {
                return -1;
            } else {
                int taxBracket = 0;
                for(int i=0; i < minIncomes.Length; i++) {
                    if(income > minIncomes[i]) {
                        taxBracket = i;
                    }
                }
                return taxBracket;  
            }
        }

        static double CalculateIncomeTax(int income, int taxBracket) {

            if(taxBracket == -1) return 0;

            int minIncome = minIncomes[taxBracket];
            double taxRate = taxRates[taxBracket];
            int basePayableAmount = basePayableAmounts[taxBracket];
            Console.WriteLine(basePayableAmount);
            double incomeTax = ((income - minIncome) * taxRate) + basePayableAmount;
            return incomeTax;
        }

        static void PrintResult(int income, double tax) {
            Console.Write("For taxable annual income of " + income.ToString("C2"));
            Console.WriteLine(", the tax payable amount is " + tax.ToString("C2"));
        }
    }   
}
