namespace BankAccounts
{
    using System;
    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The custumer's name can not be empty");
                }
                else
                {
                    this.name = value;
                }
            }

        }
    }
}
