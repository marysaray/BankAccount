using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single checking account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Get the current balance
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Deposits the amount in the bank account
        /// and returns the new balance.
        /// </summary>
        /// <param name="amt">data type double</param>
        /// <returns>The deposit amount</returns>
        public double Deposit(double amt)
        {
            if (amt >= 10000)
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(amt)} must be smaller than 10000.");
            }

            if(amt <= 0)
            {
                throw new ArgumentOutOfRangeException(
                    $"{nameof(amt)} must be a positive value.");
            }
            Balance += amt;
            return Balance;
        }

        public void Withdraw(double amt)
        {
            Balance -= amt;
        }
    }
}