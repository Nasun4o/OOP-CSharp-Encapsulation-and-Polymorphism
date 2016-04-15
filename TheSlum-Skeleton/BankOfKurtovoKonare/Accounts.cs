using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    public abstract class Accounts
    {
        private string customer;
        private double balance;
        private double interestRate;
        private CustomerType customerType;


        public Accounts(string customer, CustomerType customerType, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.CustomerType = customerType;
        }

        public string Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public CustomerType CustomerType { get; set; }


        public virtual double CalculateInterest(int periodInMonths)
        {
            double result = this.Balance * (1 + this.InterestRate * periodInMonths);
            return result;
        }


    }
}
