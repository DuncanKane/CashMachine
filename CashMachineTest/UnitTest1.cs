using System;
using CashMachine.Data.DataBase;
using CashMachine.Data.Entities;
using CashMachine.UI.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetAccountByPinTrue()
        {
            ATM _atm = new ATM(8000);
            bool fromCall;

            fromCall = _atm.GetAccountByPin(1234);

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void GetAccountByPinFalse()
        {
            ATM _atm = new ATM(8000);
            bool fromCall;

            fromCall = _atm.GetAccountByPin(5652);

            Assert.IsFalse(fromCall);
        }
        [TestMethod]
        public void HandleAccountWithdrawalTrue()
        {
            ATM _atm = new ATM(8000);
            _atm.GetAccountByPin(1234);
            string fromCall = _atm.HandleAccountWithdrawal(100);

            Assert.AreEqual(fromCall, "Your current Balance is 400");
        }
        [TestMethod]
        public void HandleAccountWithdrawalFalse()
        {
            ATM _atm = new ATM(8000);
            _atm.GetAccountByPin(1234);
            string fromCall = _atm.HandleAccountWithdrawal(100);

            Assert.AreNotEqual(fromCall, "Your current Balance is 500");
        }
        [TestMethod]
        public void GetBalanceTrue()
        {
            ATM _atm = new ATM(8000);
            _atm.GetAccountByPin(1234);
            string fromCall = _atm.GetBalance();

            Assert.AreEqual(fromCall, "Your current Balance is 500");

        }
        [TestMethod]
        public void GetBalanceFalse()
        {
            ATM _atm = new ATM(8000);
            _atm.GetAccountByPin(1234);
            string fromCall = _atm.GetBalance();

            Assert.AreNotEqual(fromCall, "Your current Balance is 400");

        }
        [TestMethod]
        public void LoginTrue()
        {
            Login _login = new Login();
            bool fromCall;

            fromCall = _login.CheckPin(1234);

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        public void LoginFalse()
        {
            Login _login = new Login();
            bool fromCall;

            fromCall = _login.CheckPin(5659);

            Assert.IsFalse(fromCall);
        }
    }
}
