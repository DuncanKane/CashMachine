using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.Data.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string DisplayName { get; set; }
        public int PIN { get; set; }
        public decimal AgreedOverDraft { get; set; } = 00.00m;
        public decimal Balance { get; set; } =  00.00m;        
        public decimal Overdraft { get; set; } = 00.00m;
        public decimal Limit { get; set; } = 250.00m;
        public bool UserLoggedIn { get; set; } = false;
    }
}
