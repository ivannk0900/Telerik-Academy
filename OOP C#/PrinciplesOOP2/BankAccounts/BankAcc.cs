namespace BankAccounts
{
    using System;
    class BankAcc
    {
        static void Main()
        {
            IndividualCustomer someCust = new IndividualCustomer("ivan");
            DepositAccount someAcc = new DepositAccount(someCust, 2000, 6);

            someAcc.WithDraw(1000);

            Console.WriteLine(someAcc.Balance);

            Console.WriteLine(someAcc.CalculateInterestAmount(14));

       

        }
    }
}
