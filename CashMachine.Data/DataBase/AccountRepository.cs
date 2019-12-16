using CashMachine.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Data.DataBase
{
    public class AccountRepository
    {
        private InMemoryDatabase _inMemoryDatabase;

        //private Account _account;

        private ATM _atm;
        
        public AccountRepository()
        {
            _inMemoryDatabase = new InMemoryDatabase();
            _atm = new ATM(8000);
        }       
        

        ~AccountRepository()
        {
            _inMemoryDatabase = null;
        }

    }
}
