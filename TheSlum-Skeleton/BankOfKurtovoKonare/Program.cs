using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    class Program
    {
        static void Main()
        {
            List<Accounts> accounts = new List<Accounts>()
            {
                new DepositeAccount("Atanas", CustomerType.individuals, 500, 2, 300, 400),
                new DepositeAccount("BUlmet Grp", CustomerType.companies, 500, 3, 300, 250),
                new LoanAccount("Toshko", CustomerType.individuals, 1000, 4, 500),
                new MortgageAccount("Atanas", CustomerType.individuals, 500, 1, 1000)

            };
            foreach (Accounts account in accounts)
            {
                Console.WriteLine("2 mounth interest on a {0} account type {1} \n\r(balance: {2:C2}, rate {3:F3}%): {4:C2}\n\r", account.Customer, account.CustomerType, account.Balance, account.InterestRate, account.CalculateInterest(2));
            }
            foreach (Accounts account in accounts)
            {
                Console.WriteLine("6 mounth interest on a {0} account type {1} \n\r(balance: {2:C2}, rate {3:F3}%): {4:C2}\n\r", account.Customer, account.CustomerType, account.Balance, account.InterestRate , account.CalculateInterest(6));
            }
            foreach (Accounts account in accounts)
            {
                Console.WriteLine("12 mounth interest on a {0} account type {1} \n\r(balance: {2:C2}, rate {3:F3}%): {4:C2}\n\r", account.Customer, account.CustomerType, account.Balance, account.InterestRate , account.CalculateInterest(12));
            }
            
        }
    }
}
