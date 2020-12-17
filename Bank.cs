using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banken
{
    class Bank : Konti
    {
        List<Konti> accounts = new List<Konti>();
        string bankName;
        double bankVault;
        public Bank(string name, int vault, string _accountname, int _accountNumber) : base(_accountname, _accountNumber)
        {
            bankName = name;
            bankVault = vault;
        }
        public string Status()
        {
            return $"************** Wellcome to {bankName} ************ \n Money in the vault:               {bankVault:c} ";
        }
        public void WriteAll()
        {

        }
        public void NewAccount(string name, int accountNumber)
        {
            Konti kon = new Konti(name, accountNumber);
            accounts.Add(kon);
        }
    }
}
