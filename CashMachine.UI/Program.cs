using CashMachine.Data.Entities;
using CashMachine.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine.UI
{
    class Program
    {
        private static ATM _atm;

        static void InitialisedTransaction()
        {
            if (_atm.account != null && _atm.account.UserLoggedIn)
            {
                bool bMenu = false;
                int iChoice = 0;
                do
                {
                    Console.WriteLine("Please select from the following options:");
                    Console.WriteLine("1: £10");
                    Console.WriteLine("2: £20");
                    Console.WriteLine("3: £50");
                    Console.WriteLine("4: £100");
                    Console.WriteLine("9: Current Balance");
                    Console.WriteLine("0: To Exit");

                    int.TryParse(Console.ReadLine(), out iChoice);
                    switch (iChoice)
                    {
                        case 1:
                            Console.WriteLine(_atm.HandleAccountWithdrawal(10));
                            InitialisedTransaction();
                            break;
                        case 2:
                            Console.WriteLine(_atm.HandleAccountWithdrawal(20));
                            InitialisedTransaction();
                            break;
                        case 3:
                            Console.WriteLine(_atm.HandleAccountWithdrawal(50));
                            InitialisedTransaction();
                            break;
                        case 4:
                            Console.WriteLine(_atm.HandleAccountWithdrawal(100));
                            InitialisedTransaction();
                            break;
                        case 9:
                            //Console.WriteLine(_atm.account.Balance);
                            Console.WriteLine($"{_atm.GetBalance()}");
                            Console.WriteLine($"{_atm.GetATMBalance()}");
                            InitialisedTransaction();
                            break;
                        case 0:
                            bMenu = true;
                            break;
                        default:
                            break;
                    }
                } while (bMenu == true);
            }
            else
            {
                Console.WriteLine("ACCOUNT_ERR");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            _atm = new ATM(8000);
                        
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("Enter you PIN:");

            var input = Console.ReadLine();            
            int.TryParse(input, out int iCheck);

            if (_atm.GetAccountByPin(iCheck))
                InitialisedTransaction();
            
        }
    }
}
