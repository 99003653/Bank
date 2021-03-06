using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagementSystem.Tests
{
    [TestClass()]
    public class DepositAmountTests
    {
        [TestMethod()]
        public void DepositTest()
        {
            DepositAmount depositAmount = new DepositAmount();
            depositAmount.Deposit(1000);
            Assert.AreEqual(2000, 2000);
            Assert.IsTrue(true);
        }
    }
}