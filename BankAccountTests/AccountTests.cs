using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void Deposit_PositiveAmount_AddsToBalance()
        {
            /* AAA : Arrange Act Assert */

            // Arrange: creating variables and object
            Account acc = new Account();
            const double startBalance = 0;
            const double initialDeposit = 100;

            // Act - Execute method under test
            acc.Deposit(initialDeposit);

            // Assert - Check a condition
            Assert.AreEqual(startBalance + initialDeposit, acc.Balance);
        }

        [TestMethod()]
        public void Deposit_PositiveAmount_ReturnsUpdatedBalance()
        {
            // Arrange: creating variables and object
            Account acc = new Account();
            double initialBalance = 0;
            double depositAmount = 10.55;

            // Act: Execute method under test
            double newBalance = acc.Deposit(depositAmount);

            // Assert: Check a condition
            double expectedBalance = initialBalance + depositAmount;
            Assert.AreEqual(expectedBalance, newBalance);
        }

        [TestMethod()]
        public void Deposit_MultipleAmounts_ReturnsAccumulatedBalance()
        {
            // Arrange: creating variables and object
            Account acc = new Account();
            double deposit1 = 10;
            double deposit2 = 25;
            double expectedBalance = deposit1 + deposit2;

            // Act: Execute method under test
            double intermediateBalance = acc.Deposit(deposit1);
            double finalBalance = acc.Deposit(deposit2);

            // Assert: Check a condition
            Assert.AreEqual(deposit1, intermediateBalance);
            Assert.AreEqual(expectedBalance, finalBalance);
        }
    }
}