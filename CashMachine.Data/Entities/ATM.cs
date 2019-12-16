using CashMachine.Data.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Data.Entities
{
    public class ATM
    {
        private InMemoryDatabase _inMemoryDatabase;
        private decimal _atmBalance { get; set; }
        
        public Account account { get; private set; }

        public ATM(decimal initialisedAmount)
        {
            _atmBalance = initialisedAmount;
            _inMemoryDatabase = new InMemoryDatabase();
        }

        public bool GetAccountByPin(int pin)
        {
            account = _inMemoryDatabase.accounts.Where(x => x.PIN == pin).FirstOrDefault();

            if (account != null)
            {
                account.UserLoggedIn = true;

                return true;
            }    
                        
            return false;
        }
        public string GetATMBalance()
        {
            string sMessage = "";

            if (account.UserLoggedIn)
            {
                return sMessage = $"Currently available to withdraw from ATM is {_atmBalance.ToString()}";
            }
            else
            {
                return String.Empty;
            }
        }

        public string GetBalance()
        {
            string sMessage = "";
            
            if (account.UserLoggedIn)
            {                
                return sMessage = $"Your current Balance is {account.Balance}";
            }
            else
            {
                return String.Empty;
            }
        }
        public string HandleAccountWithdrawal(decimal amount)
        {            
            if (account.UserLoggedIn)
            {                    
                if(_atmBalance < amount)
                {
                    return "ATM_ERROR";
                }

                if (account.Limit > amount && amount < account.Balance + account.Overdraft && amount < account.Balance)
                {
                    account.Balance = account.Balance - amount;

                    _atmBalance = _atmBalance - amount;

                    return $"Your current Balance is {account.Balance}";
                }
                else
                {
                    return "FUNDS_ERROR";
                }                
            }

            return string.Empty;
            
        }
    }
}
