using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    public class DepositeAccount : LoanAccount
    {
        
       // private decimal withdraw;

        public DepositeAccount(string customer, CustomerType customerType, double balance, double interestRate, decimal deposit, decimal withdraw) 
                        : base(customer, customerType, balance, interestRate, deposit)
        {
            this.Withdraw = withdraw;
        }


       
        public decimal Withdraw { get; set; }

        public override double CalculateInterest(int periodInMonths)
        {
            double result;
            if (this.Balance > 0 && this.Balance < 1000)
            {
                result = 0;
            }
            else
            {
                result = base.CalculateInterest(periodInMonths);
                
            }
            return result;
        }
    }
}
