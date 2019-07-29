using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Repersents a customer bank account
    /// </summary>
    public class Account
    {
        // name of account holder
        // account number
        // balance
        public string AccountNumber { get; set; }

        public string Owners { get; set; }

        public double Balance { get; set; }

        /// <summary>
        /// Adds an amount to the current balance
        /// and returns the updated balance
        /// </summary>
        /// <param name="amt"></param>
        /// <returns></returns>
        public double Deposit(double amt)
        {
            Balance += amt;
            return Balance;
            throw new NotImplementedException();
        }

        public double Withdraw(double amt)
        {
            Balance -= amt;
            return Balance;
            throw new NotImplementedException();
        }
    }
}
