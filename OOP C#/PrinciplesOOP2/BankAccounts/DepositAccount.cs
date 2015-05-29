
namespace BankAccounts
{
    using System;

    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {

        }


        public void Deposit(decimal moneyForDeposit)
        {
            this.Balance += moneyForDeposit;
            Console.WriteLine("Your money has been deposited");
        }

        public void WithDraw(decimal amount)
        {
            if(amount<0)
            {
                throw new ArgumentException("You can not with draw negative sum");
            }
            else  if (this.Balance < amount)
            {
                throw new ArgumentException("You do not have enough money to with draw");
            }
            else
            {
                this.Balance -= amount;
                Console.WriteLine("You have just with draw {0} money",amount);
            }
        }

        public override double CalculateInterestAmount(int months)
        {
            return base.CalculateInterestAmount(months);
        }
    }
}
