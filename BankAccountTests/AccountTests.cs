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
    #region /* AAA : Arrange Act Assert */
    // Arrange: creating variables and object
    // Act: Execute method under test
    // Assert:Check a condition 
    #endregion
    public class AccountTests
    {
        [TestMethod()]
        [TestCategory("Deposit")]
        [DataRow(10_000)]
        [DataRow(11234.12)]
        [DataRow(10000.01)]
        [DataRow(double.MaxValue)]
        public void Deposit_TooLarge_ThrowsArgumentException(double tooLargeDeposit)
        {
            // Arrange:
            Account acc = new Account();

            // Assert => Act:
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (
                    () => acc.Deposit(tooLargeDeposit)
                );
        }

        [TestMethod()]
        [TestCategory("Deposit")]
        [DataRow(100)]
        [DataRow(9999.99)]
        [DataRow(0.1)]
        public void Deposit_PositiveAmount_AddsToBalance(double initialDeposit)
        {
            // Arrange: 
            Account acc = new Account();
            const double startBalance = 0;

            // Act:
            acc.Deposit(initialDeposit);

            // Assert:
            Assert.AreEqual(startBalance + initialDeposit, acc.Balance);
        }

        [TestMethod()]
        [TestCategory("Deposit")]
        public void Deposit_PositiveAmount_ReturnsUpdatedBalance()
        {
            // Arrange: 
            Account acc = new Account();
            double initialBalance = 0;
            double depositAmount = 10.55;

            // Act: 
            double newBalance = acc.Deposit(depositAmount);

            // Assert: 
            double expectedBalance = initialBalance + depositAmount;
            Assert.AreEqual(expectedBalance, newBalance);
        }

        [TestMethod()]
        [TestCategory("Deposit")]
        public void Deposit_MultipleAmounts_ReturnsAccumulatedBalance()
        {
            // Arrange:
            Account acc = new Account();
            double deposit1 = 10;
            double deposit2 = 25;
            double expectedBalance = deposit1 + deposit2;

            // Act: 
            double intermediateBalance = acc.Deposit(deposit1);
            double finalBalance = acc.Deposit(deposit2);

            // Assert: 
            Assert.AreEqual(deposit1, intermediateBalance);
            Assert.AreEqual(expectedBalance, finalBalance);
        }

        [TestMethod()]
        [TestCategory("Deposit")]
        public void Deposit_NegativeAmounts_ThrowsArgumentException()
        {
            // Arrange:
            Account acc = new Account();
            double negativeDeposit = -1;

            // Assert => Act:
            Assert.ThrowsException<ArgumentOutOfRangeException>
                (
                    () => acc.Deposit(negativeDeposit)
                );
        }
    }
}