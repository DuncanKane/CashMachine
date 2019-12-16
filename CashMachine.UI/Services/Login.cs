using CashMachine.Data.DataBase;
using CashMachine.Data.Entities;
using CashMachine.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.UI.Services
{
    public class Login 
    {
        //this class was no longer need but could be used in further development 
        private InMemoryDatabase _inMemoryDatabase;

        private Account _account;

        public Login()
        {
            _inMemoryDatabase = new InMemoryDatabase();
        }
        
        public bool CheckPin(int PIN)
        {
            _account = _inMemoryDatabase.accounts.Where(x => x.PIN == PIN).FirstOrDefault();
            if (PIN == _account.PIN)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        
    }
}
