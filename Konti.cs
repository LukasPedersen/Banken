using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Konti
    {
        //Fields
        string accountName;
        double balance;
        int accountNumber;

        //Constructor
        public Konti(string _accountname, int _accountNumber)
        {
            accountName = _accountname;
            accountNumber = _accountNumber;
            balance = 0;
        }

        //properties
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
        } //ReadOnly
        public string Name
        {
            get
            {
                return accountName;
            }
        } //ReadOnly
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
        } //Read/Write
    }
}
