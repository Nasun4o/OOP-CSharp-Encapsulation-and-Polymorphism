using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    public class LoanAccount : Accounts
    {

       // private decimal deposit;
        

        public LoanAccount(string customer, CustomerType customerType, double balance, double interestRate, decimal deposit) 
                        : base(customer, customerType, balance, interestRate)
        {
            this.Deposit = deposit;
        }


        public decimal Deposit { get; set; }





        public override double CalculateInterest(int periodInMonths)
        {
            double result = 0;
            if (Equals(CustomerType.individuals))
            {
             result = (double)Balance * (1 + InterestRate * 9);
            }
            else
            {
                 result = (double)Balance * (1 + InterestRate * 10);
            }
            return result;
        }
    }
}
