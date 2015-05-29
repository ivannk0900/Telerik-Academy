using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private double interestRate;

        public Account(Customer customer, decimal balance,double interest)
        {
            this.Customer=customer;
            this.Balance=balance;
            this.InterestRate=interest;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                
                this.customer = value;
                
            }

        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }
        
        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if(this.interestRate>100||this.interestRate<0)
                {
                    throw new ArgumentException("The interest rate is between 0 and 100 percent");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }


        public virtual double CalculateInterestAmount(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Number of months cannot be negative");
            }
            return months * InterestRate;

        }
    }
}
