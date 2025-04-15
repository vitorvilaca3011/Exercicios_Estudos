using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class BankAccount
    {

        public int AccountNumber { get; private set; }

        public string _name { get; set;}
        
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, string name)
        {
            AccountNumber = accountNumber;
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }     
        
        public void AddBalance(double balance) 
        {
            Balance = Balance + balance;
        }

        public void WithdrawBalance(double balance)
        {
            double WithdrawTax = 5.0;
            Balance = Balance - balance - WithdrawTax;
        }

        public override string ToString()
        {
            return "Conta: "
                + AccountNumber
                + ", Titular: "
                + _name
                + ", Saldo: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }
}
 