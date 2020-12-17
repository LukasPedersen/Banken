using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Konti
    {
        string accountName;
        double balance;
        int accountNumber;
        public Konti(string _accountname, int _accountNumber)
        {
            accountName = _accountname;
            accountNumber = _accountNumber;
            balance = 0;
        }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        }
        public string Name
        {
            get
            {
                return accountName;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
    }
}
