
namespace BankAccounts
{
    using System;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {

        }

        public void Deposit(decimal moneyForDeposit)
        {
            this.Balance += moneyForDeposit;
            Console.WriteLine("Your money has been deposited");
        }

        public override double CalculateInterestAmount(int months)
        {

            return base.CalculateInterestAmount(months);


        }

    }
}
