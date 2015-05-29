using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, double interest)
            : base(customer, balance, interest)
        {

        }

        public void Deposit(decimal moneyForDeposit)
        {
            this.Balance += moneyForDeposit;
            Console.WriteLine("Your money has been deposited");
        }
    }
}
