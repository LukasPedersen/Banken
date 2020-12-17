using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    public class Konti
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

    //small scale Polymorfisme with virtual ond override method
    #region Date
    public class Date
    {
        public virtual string GetDate()
        {
            return DateTime.Now.ToString("dddd, dd MMMM yyyy") + "  Kl: " + DateTime.Now.ToString("HH:mm");
        }
    }
    public class Day : Date
    {
        public override string GetDate()
        {
            return DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }
    }
    public class Time : Date
    {
        public override string GetDate()
        {
            return DateTime.Now.ToString("HH:mm");
        }
    }
    #endregion
}
