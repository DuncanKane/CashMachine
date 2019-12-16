using CashMachine.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Data.Interfaces
{
    //not used but could be included in further development
    public interface IAccountData
    {       
        Account Get(int id);
        void Withdraw(Account account);        
    }
}
