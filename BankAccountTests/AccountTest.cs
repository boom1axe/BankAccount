using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    [TestClass()]
    class AccountTest
    {
        [TestMethod()]
        public void Deposit_PositiveAmount_AddsToBalance()
        {
            // AAA Pattern (Arrange, Act, Assert)

            // Arrange - Init object/varables
            Account checking = new Account();
            double depositAmt = 10;
            double expectedBalance = 10;

            // Act - Call method under test
            checking.Deposit(depositAmt);

            // Assert - Verification step
            Assert.AreEqual(expectedBalance, checking.Balance);
        }

        [TestMethod]
        public void Deposit_positiveAmount_ReturnsUpdateBalance()
        {
            // Arrange
            Account acc = new Account();
            double depositAmt = 10.55;
            double expectedReturn = 10.55;

            // Act
            double result = acc.Deposit(depositAmt);

            // Assert
            Assert.AreEqual(expectedReturn, result);
        }

        [TestMethod]
        public void MyTestMethod()
        {
            // Arrange
            Account acc = new Account();
            double depositAmt = -1;

            // Act => Assert
            Assert.ThrowsException<ArgumentException>
                (() => acc.Deposit(depositAmt));
        }
    }
}
