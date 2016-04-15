using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
   public class MortgageAccount : LoanAccount
    {
        public MortgageAccount(string customer, CustomerType customerType, double balance, double interestRate, decimal deposit) 
                        :base(customer, customerType, balance, interestRate, deposit)
        {
        }


        public override double CalculateInterest(int periodInMonths)
        {
            if (Equals(CustomerType.companies))
            {
                double result = Balance * (1 + InterestRate * 12);
                return result;
            }
            else
            {
                double result = Balance * (1 + InterestRate * 6);
                return result;
            }
        }

    }
}
