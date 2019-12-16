using CashMachine.Data.Entities;
using CashMachine.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Data.DataBase
{
    public class InMemoryDatabase //: IAccountData
    {
        
        public List<Account> accounts{ get; private set; }
        public InMemoryDatabase()
        {
            accounts = new List<Account>()
            {
                new Account{ Number = 12345678, DisplayName = "Mr Dave Dongs", PIN=1234, Balance=500, AgreedOverDraft=100.00m},
                new Account{ Number = 87654321, DisplayName = "Mr Frank Bone", PIN=4321, Balance=100, AgreedOverDraft=00.00m}
            };
        }
       
    }
}
